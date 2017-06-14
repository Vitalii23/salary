namespace salary
{
    partial class Wage
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxChange = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.listViewWorkers = new System.Windows.Forms.ListView();
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.numericUpDownPayPerMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHourInMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPayPerHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonMonthlyPay = new System.Windows.Forms.RadioButton();
            this.radioButtonHourPay = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.listViewSalary = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxSalary = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxChange.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayPerMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourInMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayPerHour)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxSalary.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChange
            // 
            this.groupBoxChange.Controls.Add(this.buttonRemove);
            this.groupBoxChange.Controls.Add(this.label8);
            this.groupBoxChange.Controls.Add(this.textBoxFind);
            this.groupBoxChange.Controls.Add(this.listViewWorkers);
            this.groupBoxChange.Location = new System.Drawing.Point(305, 29);
            this.groupBoxChange.Name = "groupBoxChange";
            this.groupBoxChange.Size = new System.Drawing.Size(428, 234);
            this.groupBoxChange.TabIndex = 1;
            this.groupBoxChange.TabStop = false;
            this.groupBoxChange.Text = "Сотрудники";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(269, 202);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(119, 23);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Поиск";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(64, 204);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(152, 20);
            this.textBoxFind.TabIndex = 15;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged_1);
            // 
            // listViewWorkers
            // 
            this.listViewWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewWorkers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSurname,
            this.columnHeaderName,
            this.columnHeaderDateBirthday});
            this.listViewWorkers.FullRowSelect = true;
            this.listViewWorkers.GridLines = true;
            this.listViewWorkers.Location = new System.Drawing.Point(6, 17);
            this.listViewWorkers.MultiSelect = false;
            this.listViewWorkers.Name = "listViewWorkers";
            this.listViewWorkers.Size = new System.Drawing.Size(416, 179);
            this.listViewWorkers.TabIndex = 2;
            this.listViewWorkers.UseCompatibleStateImageBehavior = false;
            this.listViewWorkers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Фамилия";
            this.columnHeaderSurname.Width = 105;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 90;
            // 
            // columnHeaderDateBirthday
            // 
            this.columnHeaderDateBirthday.Text = "Дата рождения";
            this.columnHeaderDateBirthday.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerDateBirthday);
            this.groupBox2.Controls.Add(this.textBoxPatronymic);
            this.groupBox2.Controls.Add(this.textBoxSurname);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.buttonChange);
            this.groupBox2.Controls.Add(this.numericUpDownPayPerMonth);
            this.groupBox2.Controls.Add(this.numericUpDownHourInMonth);
            this.groupBox2.Controls.Add(this.numericUpDownPayPerHour);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "+++++";
            // 
            // dateTimePickerDateBirthday
            // 
            this.dateTimePickerDateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateBirthday.Location = new System.Drawing.Point(156, 104);
            this.dateTimePickerDateBirthday.Name = "dateTimePickerDateBirthday";
            this.dateTimePickerDateBirthday.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDateBirthday.TabIndex = 31;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(156, 78);
            this.textBoxPatronymic.MaxLength = 25;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatronymic.TabIndex = 30;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(156, 19);
            this.textBoxSurname.MaxLength = 20;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 28;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(156, 51);
            this.textBoxName.MaxLength = 15;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 29;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(21, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 23);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(32, 178);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(105, 23);
            this.buttonChange.TabIndex = 26;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click_1);
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
            this.numericUpDownPayPerMonth.Location = new System.Drawing.Point(144, 284);
            this.numericUpDownPayPerMonth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPayPerMonth.Name = "numericUpDownPayPerMonth";
            this.numericUpDownPayPerMonth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPayPerMonth.TabIndex = 22;
            this.numericUpDownPayPerMonth.ThousandsSeparator = true;
            // 
            // numericUpDownHourInMonth
            // 
            this.numericUpDownHourInMonth.DecimalPlaces = 1;
            this.numericUpDownHourInMonth.InterceptArrowKeys = false;
            this.numericUpDownHourInMonth.Location = new System.Drawing.Point(144, 252);
            this.numericUpDownHourInMonth.Maximum = new decimal(new int[] {
            744,
            0,
            0,
            0});
            this.numericUpDownHourInMonth.Name = "numericUpDownHourInMonth";
            this.numericUpDownHourInMonth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownHourInMonth.TabIndex = 21;
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
            this.numericUpDownPayPerHour.Location = new System.Drawing.Point(144, 219);
            this.numericUpDownPayPerHour.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPayPerHour.Name = "numericUpDownPayPerHour";
            this.numericUpDownPayPerHour.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPayPerHour.TabIndex = 20;
            this.numericUpDownPayPerHour.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Плата за месяц";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Часы за месяц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Плата за час";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonMonthlyPay);
            this.groupBox3.Controls.Add(this.radioButtonHourPay);
            this.groupBox3.Location = new System.Drawing.Point(156, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 64);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип зарплаты";
            // 
            // radioButtonMonthlyPay
            // 
            this.radioButtonMonthlyPay.AutoSize = true;
            this.radioButtonMonthlyPay.Location = new System.Drawing.Point(12, 42);
            this.radioButtonMonthlyPay.Name = "radioButtonMonthlyPay";
            this.radioButtonMonthlyPay.Size = new System.Drawing.Size(75, 17);
            this.radioButtonMonthlyPay.TabIndex = 8;
            this.radioButtonMonthlyPay.Text = "Месячная";
            this.radioButtonMonthlyPay.UseVisualStyleBackColor = true;
            // 
            // radioButtonHourPay
            // 
            this.radioButtonHourPay.AutoSize = true;
            this.radioButtonHourPay.Checked = true;
            this.radioButtonHourPay.Location = new System.Drawing.Point(12, 19);
            this.radioButtonHourPay.Name = "radioButtonHourPay";
            this.radioButtonHourPay.Size = new System.Drawing.Size(80, 17);
            this.radioButtonHourPay.TabIndex = 9;
            this.radioButtonHourPay.TabStop = true;
            this.radioButtonHourPay.Text = "Почасовая";
            this.radioButtonHourPay.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(290, 180);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 12;
            this.Deletebutton.Text = "Удалить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // listViewSalary
            // 
            this.listViewSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSalary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewSalary.FullRowSelect = true;
            this.listViewSalary.GridLines = true;
            this.listViewSalary.Location = new System.Drawing.Point(6, 19);
            this.listViewSalary.Name = "listViewSalary";
            this.listViewSalary.Size = new System.Drawing.Size(422, 155);
            this.listViewSalary.TabIndex = 1;
            this.listViewSalary.UseCompatibleStateImageBehavior = false;
            this.listViewSalary.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Фамилия";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Имя";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата зарплаты";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Зарплата";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxSalary
            // 
            this.groupBoxSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSalary.Controls.Add(this.listViewSalary);
            this.groupBoxSalary.Controls.Add(this.Deletebutton);
            this.groupBoxSalary.Controls.Add(this.button2);
            this.groupBoxSalary.Location = new System.Drawing.Point(305, 269);
            this.groupBoxSalary.Name = "groupBoxSalary";
            this.groupBoxSalary.Size = new System.Drawing.Size(428, 210);
            this.groupBoxSalary.TabIndex = 13;
            this.groupBoxSalary.TabStop = false;
            this.groupBoxSalary.Text = "Зарплата";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.removeToolStripMenuItem.Text = "Удалить";
            // 
            // openFileDialogOpen
            // 
            this.openFileDialogOpen.Filter = "xml files (*.xml)|*.xml";
            this.openFileDialogOpen.InitialDirectory = "Application.StartupPath";
            this.openFileDialogOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogOpen_FileOk_1);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(793, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.fhToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newToolStripMenuItem.Text = "Новая";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // fhToolStripMenuItem
            // 
            this.fhToolStripMenuItem.Name = "fhToolStripMenuItem";
            this.fhToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fhToolStripMenuItem.Text = "fh";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "xml files (*.xml)|*.xml";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk_1);
            // 
            // Wage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 491);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxSalary);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxChange);
            this.Name = "Wage";
            this.Text = "Зараплатная плата";
            this.groupBoxChange.ResumeLayout(false);
            this.groupBoxChange.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayPerMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourInMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayPerHour)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSalary.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewWorkers;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDateBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonMonthlyPay;
        private System.Windows.Forms.RadioButton radioButtonHourPay;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBirthday;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.NumericUpDown numericUpDownPayPerMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownHourInMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownPayPerHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.ListView listViewSalary;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxSalary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpen;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fhToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdd;
    }
}

