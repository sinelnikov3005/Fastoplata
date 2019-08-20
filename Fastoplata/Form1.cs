// --- Черновик --- start ---
#region Черновик
//private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
//{
//    char number = e.KeyChar;
//    if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
//    {
//        e.Handled = true;
//    }
//}
#endregion Черновик
// --- Черновик --- finish ---




// --- Зависимости --- start ---
#region Зависимости
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
#endregion
// --- Зависимости --- finish ---




// --- ТЕЛО --- START ---
#region ТЕЛО
namespace Fastoplata
{
    public partial class Form1 : Form
    {
        // --- Константы и Переменные --- start ---
        #region Константы и Переменные
        // Firebase
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "t71hmbJc9dLMBqvwbaZK1cfinjayzbVamzl6Swbd",
            BasePath = "https://fastoplata.firebaseio.com/"
        };
        IFirebaseClient client;

        // Selenium
        IWebDriver driver;
        String site = "https://oplata.lifecell.ua";
        #endregion
        // --- Константы и Переменные --- finish ---




        // --- Форма --- start ---
        #region Форма
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                //MessageBox.Show("Connection is established!\n\nСоединение установлено!");
            }
        }
        #endregion Форма
        // --- Форма --- finish ---




        // --- Работа с DB --- start ---
        #region Работа с DB
        private async void ButtonSave_ClickAsync(object sender, EventArgs e)
        {
            var data = new Data
            {
                Name = comboBoxName.Text,
                Mobile = maskedTextBoxMobile.Text,
                Sum = maskedTextBoxSum.Text,
                Card = maskedTextBoxCard.Text                
            };

            SetResponse response = await client.SetTaskAsync(
                "Information/" + comboBoxName.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Данные сохранены! " + result.Name);            
        }


        private async void ButtonLoad_ClickAsync(object sender, EventArgs e)
        {
            try
            {                
                FirebaseResponse response = await client.GetTaskAsync(
                    "Information/" + comboBoxName.Text);
                Data obj = response.ResultAs<Data>();

                comboBoxName.Text = obj.Name;
                maskedTextBoxMobile.Text = obj.Mobile;
                maskedTextBoxSum.Text = obj.Sum;
                maskedTextBoxCard.Text = obj.Card;

                MessageBox.Show("Данные загружены!");
            }
            catch
            {
                MessageBox.Show("Ошибка!\nДаное имя отсутствует!");
            }
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            //FirebaseResponse response = await client.GetTaskAsync(
            //        "Information/" + );
            //Data ob = response.ResultAs<Data>();
            //comboBoxName.Items.Add = ob.Name;
        }
        #endregion
        // --- Работа с DB --- finish ---




        // --- Логика автоматизации Selenium --- start ---
        #region Логика автоматизации Selenium
        private void ButtonOplata_Click(object sender, EventArgs e)
        {
            //Запуск браузера
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Зайти на сайт
            driver.Navigate().GoToUrl(site);

            //Номер телефона
            IWebElement myMobileNumber = driver.FindElement(By.XPath(
                "//input[@placeholder='0XX XXX XX XX или контракт']"));
            myMobileNumber.SendKeys(maskedTextBoxMobile.Text);

            //Сумма пополнения
            IWebElement myRefillAmount = driver.FindElement(By.XPath(
                "//input[@name='amount']"));
            myRefillAmount.SendKeys(OpenQA.Selenium.Keys.Backspace);
            myRefillAmount.SendKeys(OpenQA.Selenium.Keys.Backspace);
            myRefillAmount.SendKeys(OpenQA.Selenium.Keys.Backspace);
            myRefillAmount.SendKeys(OpenQA.Selenium.Keys.Backspace);
            myRefillAmount.SendKeys(maskedTextBoxSum.Text);

            //Номер платежной карты
            IWebElement myPaymentCard = driver.FindElement(By.XPath(
                "//input[@name='card_id']"));
            myPaymentCard.Click();
            myPaymentCard.SendKeys(maskedTextBoxCard.Text);

            //Оплата
            IWebElement myPay = driver.FindElement(By.XPath(
                "//button[@class='Button--base--2L7VTMB Button--medium--1ljykma Button--primary--MF3jdCv base--buttonMin190--1hYfPhr Button--canHover--2HNlYC1']"));
            myPay.Click();
        }
        #endregion
        // --- Логика автоматизации Selenium --- finish ---




        // --- Выключение chromedriver --- start ---
        #region Выключение chromedriver и формы
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            //Закрыть Chrome
            try
            {
                driver.Quit();
            }
            catch
            {
                MessageBox.Show("Браузер закрыт!");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                driver.Quit();
            }
            catch
            {
                //Close();
            }
        }
        #endregion
        // --- Выключение chromedriver --- finish ---




        // --- Переключение между Виджетами кнопкой "Enter" --- start ---
        #region Переключение между Виджетами кнопкой "Enter"
        private void ComboBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                if (sender.Equals(comboBoxName))
                    maskedTextBoxMobile.Focus();
            }
        }

        private void MaskedTextBoxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                if (sender.Equals(maskedTextBoxMobile))
                    maskedTextBoxSum.Focus();
            }
        }

        private void MaskedTextBoxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                if (sender.Equals(maskedTextBoxSum))
                    maskedTextBoxCard.Focus();
            }
        }

        private void MaskedTextBoxCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                if (sender.Equals(maskedTextBoxCard))
                    buttonOplata.Focus();
            }
        }        
        #endregion
        // --- Переключение между Виджетами кнопкой "Enter" --- finish ---
    }
}
#endregion
// --- ТЕЛО --- FINISH ---
