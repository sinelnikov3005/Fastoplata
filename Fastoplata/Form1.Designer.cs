namespace Fastoplata
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maskedTextBoxMobile = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCard = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.labelFastoplata = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOplata = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxMobile
            // 
            this.maskedTextBoxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.maskedTextBoxMobile.Location = new System.Drawing.Point(12, 149);
            this.maskedTextBoxMobile.Mask = "(999) 000-00-00";
            this.maskedTextBoxMobile.Name = "maskedTextBoxMobile";
            this.maskedTextBoxMobile.Size = new System.Drawing.Size(260, 26);
            this.maskedTextBoxMobile.TabIndex = 4;
            this.maskedTextBoxMobile.Text = "0937602748";
            this.maskedTextBoxMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskedTextBoxMobile_KeyPress);
            // 
            // maskedTextBoxSum
            // 
            this.maskedTextBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.maskedTextBoxSum.Location = new System.Drawing.Point(12, 181);
            this.maskedTextBoxSum.Mask = "000";
            this.maskedTextBoxSum.Name = "maskedTextBoxSum";
            this.maskedTextBoxSum.Size = new System.Drawing.Size(260, 26);
            this.maskedTextBoxSum.TabIndex = 5;
            this.maskedTextBoxSum.Text = "130";
            this.maskedTextBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskedTextBoxSum_KeyPress);
            // 
            // maskedTextBoxCard
            // 
            this.maskedTextBoxCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.maskedTextBoxCard.Location = new System.Drawing.Point(12, 213);
            this.maskedTextBoxCard.Mask = "0000 0000 0000 0000";
            this.maskedTextBoxCard.Name = "maskedTextBoxCard";
            this.maskedTextBoxCard.Size = new System.Drawing.Size(260, 26);
            this.maskedTextBoxCard.TabIndex = 6;
            this.maskedTextBoxCard.Text = "1111222233334444";
            this.maskedTextBoxCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskedTextBoxCard_KeyPress);
            // 
            // comboBoxName
            // 
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(12, 43);
            this.comboBoxName.MaxLength = 20;
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxName.Size = new System.Drawing.Size(260, 28);
            this.comboBoxName.TabIndex = 1;
            this.comboBoxName.Text = "Имя";
            this.comboBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxName_KeyPress);
            // 
            // labelFastoplata
            // 
            this.labelFastoplata.AutoSize = true;
            this.labelFastoplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFastoplata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.labelFastoplata.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelFastoplata.Location = new System.Drawing.Point(82, 9);
            this.labelFastoplata.Name = "labelFastoplata";
            this.labelFastoplata.Size = new System.Drawing.Size(125, 29);
            this.labelFastoplata.TabIndex = 9;
            this.labelFastoplata.Text = "Fastoplata";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.buttonSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSave.Location = new System.Drawing.Point(12, 245);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(260, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_ClickAsync);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(12, 327);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(260, 30);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Закрыть браузер";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonOplata
            // 
            this.buttonOplata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.buttonOplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOplata.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonOplata.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOplata.Location = new System.Drawing.Point(12, 281);
            this.buttonOplata.Name = "buttonOplata";
            this.buttonOplata.Size = new System.Drawing.Size(260, 40);
            this.buttonOplata.TabIndex = 8;
            this.buttonOplata.Text = "Оплата";
            this.buttonOplata.UseVisualStyleBackColor = false;
            this.buttonOplata.Click += new System.EventHandler(this.ButtonOplata_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.buttonLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLoad.Location = new System.Drawing.Point(12, 77);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(260, 30);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_ClickAsync);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.buttonDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDelete.Location = new System.Drawing.Point(12, 113);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(260, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fastoplata.Properties.Resources.image_lifecell;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOplata);
            this.Controls.Add(this.labelFastoplata);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.maskedTextBoxCard);
            this.Controls.Add(this.maskedTextBoxSum);
            this.Controls.Add(this.maskedTextBoxMobile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fastoplata";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMobile;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSum;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCard;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label labelFastoplata;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOplata;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonDelete;
    }
}

