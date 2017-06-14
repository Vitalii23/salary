namespace salary
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownPayPerMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHourInMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPayPerHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonHourPay = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthlyPay = new System.Windows.Forms.RadioButton();
            this.buttonNFAdd = new System.Windows.Forms.Button();
            this.labelDateBirthday = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dateTimePickerDateBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayPerMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourInMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayPerHour)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownPayPerMonth
            // 
            this.numericUpDownPayPerMonth.DecimalPlaces = 2;
            this.numericUpDownPayPerMonth.Enabled = false;
            this.numericUpDownPayPerMonth.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPayPerMonth.InterceptArrowKeys = false;
            this.numericUpDownPayPerMonth.Location = new System.Drawing.Point(143, 244);
            this.numericUpDownPayPerMonth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPayPerMonth.Name = "numericUpDownPayPerMonth";
            this.numericUpDownPayPerMonth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPayPerMonth.TabIndex = 49;
            this.numericUpDownPayPerMonth.ThousandsSeparator = true;
            // 
            // numericUpDownHourInMonth
            // 
            this.numericUpDownHourInMonth.DecimalPlaces = 1;
            this.numericUpDownHourInMonth.InterceptArrowKeys = false;
            this.numericUpDownHourInMonth.Location = new System.Drawing.Point(143, 218);
            this.numericUpDownHourInMonth.Maximum = new decimal(new int[] {
            744,
            0,
            0,
            0});
            this.numericUpDownHourInMonth.Name = "numericUpDownHourInMonth";
            this.numericUpDownHourInMonth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownHourInMonth.TabIndex = 47;
            // 
            // numericUpDownPayPerHour
            // 
            this.numericUpDownPayPerHour.DecimalPlaces = 2;
            this.numericUpDownPayPerHour.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPayPerHour.InterceptArrowKeys = false;
            this.numericUpDownPayPerHour.Location = new System.Drawing.Point(143, 192);
            this.numericUpDownPayPerHour.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPayPerHour.Name = "numericUpDownPayPerHour";
            this.numericUpDownPayPerHour.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPayPerHour.TabIndex = 45;
            this.numericUpDownPayPerHour.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Плата за месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Часы за месяц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Плата за час";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonHourPay);
            this.groupBox3.Controls.Add(this.radioButtonMonthlyPay);
            this.groupBox3.Location = new System.Drawing.Point(74, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 70);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип";
            // 
            // radioButtonHourPay
            // 
            this.radioButtonHourPay.AutoSize = true;
            this.radioButtonHourPay.Checked = true;
            this.radioButtonHourPay.Location = new System.Drawing.Point(11, 19);
            this.radioButtonHourPay.Name = "radioButtonHourPay";
            this.radioButtonHourPay.Size = new System.Drawing.Size(80, 17);
            this.radioButtonHourPay.TabIndex = 1;
            this.radioButtonHourPay.TabStop = true;
            this.radioButtonHourPay.Text = "Почасовая";
            this.radioButtonHourPay.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthlyPay
            // 
            this.radioButtonMonthlyPay.AutoSize = true;
            this.radioButtonMonthlyPay.Location = new System.Drawing.Point(11, 42);
            this.radioButtonMonthlyPay.Name = "radioButtonMonthlyPay";
            this.radioButtonMonthlyPay.Size = new System.Drawing.Size(75, 17);
            this.radioButtonMonthlyPay.TabIndex = 0;
            this.radioButtonMonthlyPay.Text = "Месячная";
            this.radioButtonMonthlyPay.UseVisualStyleBackColor = true;
            // 
            // buttonNFAdd
            // 
            this.buttonNFAdd.Location = new System.Drawing.Point(116, 298);
            this.buttonNFAdd.Name = "buttonNFAdd";
            this.buttonNFAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonNFAdd.TabIndex = 52;
            this.buttonNFAdd.Text = "Добавить";
            this.buttonNFAdd.UseVisualStyleBackColor = true;
            // 
            // labelDateBirthday
            // 
            this.labelDateBirthday.AutoSize = true;
            this.labelDateBirthday.Location = new System.Drawing.Point(31, 88);
            this.labelDateBirthday.Name = "labelDateBirthday";
            this.labelDateBirthday.Size = new System.Drawing.Size(86, 13);
            this.labelDateBirthday.TabIndex = 51;
            this.labelDateBirthday.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 50;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(31, 62);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 48;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(37, 6);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 46;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 43;
            this.labelName.Text = "Имя";
            // 
            // dateTimePickerDateBirthday
            // 
            this.dateTimePickerDateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateBirthday.Location = new System.Drawing.Point(143, 81);
            this.dateTimePickerDateBirthday.Name = "dateTimePickerDateBirthday";
            this.dateTimePickerDateBirthday.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDateBirthday.TabIndex = 42;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(143, 55);
            this.textBoxPatronymic.MaxLength = 25;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatronymic.TabIndex = 41;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(143, 3);
            this.textBoxSurname.MaxLength = 20;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 39;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 29);
            this.textBoxName.MaxLength = 15;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 336);
            this.Controls.Add(this.numericUpDownPayPerMonth);
            this.Controls.Add(this.numericUpDownHourInMonth);
            this.Controls.Add(this.numericUpDownPayPerHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonNFAdd);
            this.Controls.Add(this.labelDateBirthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dateTimePickerDateBirthday);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form2";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayPerMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourInMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayPerHour)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown numericUpDownPayPerMonth;
        public System.Windows.Forms.NumericUpDown numericUpDownHourInMonth;
        public System.Windows.Forms.NumericUpDown numericUpDownPayPerHour;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton radioButtonHourPay;
        public System.Windows.Forms.RadioButton radioButtonMonthlyPay;
        public System.Windows.Forms.Button buttonNFAdd;
        public System.Windows.Forms.Label labelDateBirthday;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelPatronymic;
        public System.Windows.Forms.Label labelSurname;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.DateTimePicker dateTimePickerDateBirthday;
        public System.Windows.Forms.TextBox textBoxPatronymic;
        public System.Windows.Forms.TextBox textBoxSurname;
        public System.Windows.Forms.TextBox textBoxName;
    }
}