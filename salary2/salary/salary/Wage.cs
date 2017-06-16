using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace salary
{
    public partial class Wage : Form
    {

        private Form2 form2 = new Form2();
        // private List<IEmployer> ListEmplployee = new List<IEmployer>();
        private Dictionary<string, IEmployer> IndexEmplployee = new Dictionary<string, IEmployer>();

        private string filePath;
        private bool changes;
        private const string formName = " - База сотрудника";

        public Wage()
        {

            var d = new Database();
            
            d.onAdd((IEmployer employer) => {
                // добавить этих сотрудников в модель таблицы
                var it = new ListViewItem(employer.Surname);
                it.SubItems.Add(employer.Name);
                it.SubItems.Add(employer.DateBirthday.ToShortDateString());

                listViewWorkers.Items.Add(it);
            });

            d.onFlush(() => {
                listViewWorkers.Clear();
            });

            // d.loadfile("asd");
            // d.savefile("asd");


            AddOwnedForm(form2);
            form2.textBoxSurname.Validating += textBoxSurname_Validating;
            form2.textBoxSurname.KeyPress += textBoxSurname_KeyPress;
            form2.textBoxSurname.Enter += textBox_Enter;
            form2.textBoxName.Validating += textBoxName_Validating;
            form2.textBoxName.KeyPress += textBoxName_KeyPress;
            form2.textBoxName.Enter += textBox_Enter;
            form2.textBoxPatronymic.Validating += textBoxPatronymic_Validating;
            form2.textBoxPatronymic.KeyPress += textBoxName_KeyPress;
            form2.textBoxPatronymic.Enter += textBox_Enter;
            form2.radioButtonMonthlyPay.CheckedChanged += radioButtonMonthlyPayFormAdd_CheckedChanged;
            form2.radioButtonHourPay.CheckedChanged += radioButtonHourPayFormAdd_CheckedChanged;
            form2.buttonNFAdd.Click += (senderSlave, eSlave) =>
            {
                if (NotEmptyFieldsFormAdd())
                {
                    if (textBoxFind.Text != "")
                    {
                        textBoxFind.Text = "";
                        return;
                    }
                    ConstructListView();
                    if (form2.radioButtonMonthlyPay.Checked)
                    {
                        var p = new EmployerMonth
                        {
                            Type = TypePayment.MonthPay,
                            Name = form2.textBoxName.Text,
                            Surname = form2.textBoxSurname.Text,
                            Patronymic = form2.textBoxPatronymic.Text,
                            DateBirthday = form2.dateTimePickerDateBirthday.Value,
                            PayPerMonth = form2.numericUpDownPayPerMonth.Value,
                            ListSalary = new List<Salary>(),
                        };
                        var it = new ListViewItem(p.Surname);
                        it.SubItems.Add(p.Name);
                        it.SubItems.Add(p.DateBirthday.ToShortDateString());
                        IEmployer worker = p;
                        string listKey = p.Surname + p.Name + p.DateBirthday.ToShortDateString();
                        try
                        {
                            IndexEmplployee.Add(listKey, worker);
                            listViewWorkers.Items.Add(it);
                            // ListEmplployee.Add(p);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Человек с такими данными уже существует.");
                        }
                    }
                    else
                    {
                        var p = new EmployerHour
                        {
                            Type = TypePayment.HourPay,
                            Name = form2.textBoxName.Text,
                            Surname = form2.textBoxSurname.Text,
                            Patronymic = form2.textBoxPatronymic.Text,
                            DateBirthday = form2.dateTimePickerDateBirthday.Value,
                            PayPerHour = form2.numericUpDownPayPerHour.Value,
                            HourInMonth = form2.numericUpDownHourInMonth.Value,
                            ListSalary = new List<Salary>(),
                        };
                        var it = new ListViewItem(p.Surname);
                        it.SubItems.Add(p.Name);
                        it.SubItems.Add(p.DateBirthday.ToShortDateString());
                        IEmployer worker = p;
                        string listKey = p.Surname + p.Name + p.DateBirthday.ToShortDateString();
                        try
                        {
                            IndexEmplployee.Add(listKey, worker);
                            listViewWorkers.Items.Add(it);
                            // ListEmplployee.Add(p);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Человек с такими данными уже существует");
                        }

                    }
                    ClearFieldsFormAdd();
                    textBoxName.BackColor = SystemColors.Window;
                    textBoxSurname.BackColor = SystemColors.Window;
                    form2.Hide();
                    changes = true;
                }
                else
                {
                    ColorFieldFormAdd();
                }

            };
            InitializeComponent();
        }
        /// <summary>
        /// Изменение данных сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click_1(object sender, EventArgs e)
        {
            if (listViewWorkers.SelectedItems.Count != 0)
            {
                if (NotEmptyFields())
                {
                    //textBoxFind.Text = "";
                   IEmployer dictonaryValue;

                    string key = listViewWorkers.SelectedItems[0].SubItems[0].Text;
                    key += listViewWorkers.SelectedItems[0].SubItems[1].Text;
                    key += listViewWorkers.SelectedItems[0].SubItems[2].Text;

                    if (IndexEmplployee.TryGetValue(key, out dictonaryValue)) { }
                    if (radioButtonMonthlyPay.Checked)
                    {
                        var p = new EmployerMonth
                        {
                            Type = TypePayment.MonthPay,
                            Name = textBoxName.Text,
                            Surname = textBoxSurname.Text,
                            Patronymic = textBoxPatronymic.Text,
                            DateBirthday = dateTimePickerDateBirthday.Value,
                            PayPerMonth = numericUpDownPayPerMonth.Value,
                            ListSalary = dictonaryValue.ListSalary,
                        };
                        // ListEmplployee[ListEmplployee.IndexOf(dictonaryValue)] = p;
                        listViewWorkers.SelectedItems[0].SubItems[0].Text = p.Surname;
                        listViewWorkers.SelectedItems[0].SubItems[1].Text = p.Name;
                        listViewWorkers.SelectedItems[0].SubItems[2].Text = p.DateBirthday.ToShortDateString();

                        // IndexEmplployee.Remove(key);
                        key = p.Surname + p.Name + p.DateBirthday.ToShortDateString();
                        //IndexEmplployee.Add(key, p);
                    }
                    else
                    {
                        var p = new EmployerHour
                        {
                            Type = TypePayment.HourPay,
                            Name = textBoxName.Text,
                            Surname = textBoxSurname.Text,
                            Patronymic = textBoxPatronymic.Text,
                            DateBirthday = dateTimePickerDateBirthday.Value,
                            PayPerHour = numericUpDownPayPerHour.Value,
                            HourInMonth = numericUpDownHourInMonth.Value,
                            ListSalary = dictonaryValue.ListSalary,
                        };

                        //ListEmplployee[ListEmplployee.IndexOf(dictonaryValue)] = p;
                        listViewWorkers.SelectedItems[0].SubItems[0].Text = p.Surname;
                        listViewWorkers.SelectedItems[0].SubItems[1].Text = p.Name;
                        listViewWorkers.SelectedItems[0].SubItems[2].Text = p.DateBirthday.ToShortDateString();

                        IndexEmplployee.Remove(key);
                        key = p.Surname + p.Name + p.DateBirthday.ToShortDateString();
                        IndexEmplployee.Add(key, p);
                    }
                    changes = true;
                }
                else
                {
                    ColorField();
                }
            }
        }

        /// <summary>
        /// Добавление сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            form2.ShowDialog();
           //var employer = form2.Employer;
        }

        /// <summary>
        /// Удаление сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            Remove();
            changes = true;
        }

        /// <summary>
        /// Очистить выделение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearSelection_Click_1(object sender, EventArgs e)
        {
            listViewWorkers.SelectedItems.Clear();
        }

        /// <summary>
        /// Переключение полей ввода зарплаты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMonthlyPay_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownPayPerMonth.Enabled = true;
            numericUpDownPayPerHour.Enabled = false;
            numericUpDownHourInMonth.Enabled = false;
        }

        /// <summary>
        /// Переключение полей ввода зарплаты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonHourPay_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownPayPerMonth.Enabled = false;
            numericUpDownPayPerHour.Enabled = true;
            numericUpDownHourInMonth.Enabled = true;
        }

        /// <summary>
        /// Переключение полей ввода зарплаты формы добавления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMonthlyPayFormAdd_CheckedChanged(object sender, EventArgs e)
        {
            form2.numericUpDownPayPerMonth.Enabled = true;
            form2.numericUpDownPayPerHour.Enabled = false;
            form2.numericUpDownHourInMonth.Enabled = false;
        }

        /// <summary>
        /// Переключение полей ввода зарплаты формы добавления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonHourPayFormAdd_CheckedChanged(object sender, EventArgs e)
        {
            form2.numericUpDownPayPerMonth.Enabled = false;
            form2.numericUpDownPayPerHour.Enabled = true;
            form2.numericUpDownHourInMonth.Enabled = true;
        }

        /// <summary>
        /// Занести зарплату сотрудника и показать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewWorkers.SelectedItems.Count != 0)
            {
                IEmployer dictonaryValue;

                string key = listViewWorkers.SelectedItems[0].SubItems[0].Text;
                key += listViewWorkers.SelectedItems[0].SubItems[1].Text;
                key += listViewWorkers.SelectedItems[0].SubItems[2].Text;

                if (IndexEmplployee.TryGetValue(key, out dictonaryValue)) { }

                Salary a = new Salary();
                a.Amount = dictonaryValue.CalcMonthPay();
                a.DateSalary = DateTime.Now;
                dictonaryValue.ListSalary.Add(a);
                listViewSalary.Items.Clear();
                
                foreach (Salary s in dictonaryValue.ListSalary)
                {
                    var it = new ListViewItem(dictonaryValue.Surname);
                    it.SubItems.Add(dictonaryValue.Name);
                    it.SubItems.Add(s.DateSalary.ToString());
                    it.SubItems.Add(s.Amount.ToString());
                    listViewSalary.Items.Add(it);
                }
                

                changes = true;
            }
        }

        /// <summary>
        /// Передача информации в поля ввода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (listViewWorkers.SelectedItems.Count != 0)
            {
                groupBoxChange.Enabled = true;
                IEmployer dictonaryValue;
                string key = listViewWorkers.SelectedItems[0].SubItems[0].Text;
                key += listViewWorkers.SelectedItems[0].SubItems[1].Text;
                key += listViewWorkers.SelectedItems[0].SubItems[2].Text;

                // if (IndexEmplployee.TryGetValue(key, out dictonaryValue)) { }
                
                if (dictonaryValue.ListSalary.Count != 0)
                {
                    listViewSalary.Items.Clear();
                    foreach (Salary s in dictonaryValue.ListSalary)
                    {
                        var it = new ListViewItem(dictonaryValue.Surname);
                        it.SubItems.Add(dictonaryValue.Name);
                        it.SubItems.Add(s.DateSalary.ToString());
                        it.SubItems.Add(s.Amount.ToString());
                        listViewSalary.Items.Add(it);
                    }
                }

                switch (dictonaryValue.Type)
                {
                    case TypePayment.MonthPay:
                        radioButtonMonthlyPay.Checked = true;
                        var te = (EmployerMonth)dictonaryValue;
                        textBoxName.Text = te.Name;
                        textBoxSurname.Text = te.Surname;
                        textBoxPatronymic.Text = te.Patronymic;
                        dateTimePickerDateBirthday.Value = te.DateBirthday;
                        numericUpDownPayPerMonth.Value = te.PayPerMonth;
                        break;

                    case TypePayment.HourPay:
                        radioButtonHourPay.Checked = true;
                        var te2 = (EmployerHour)dictonaryValue;
                        textBoxName.Text = te2.Name;
                        textBoxSurname.Text = te2.Surname;
                        textBoxPatronymic.Text = te2.Patronymic;
                        dateTimePickerDateBirthday.Value = te2.DateBirthday;
                        numericUpDownPayPerHour.Value = te2.PayPerHour;
                        numericUpDownHourInMonth.Value = te2.HourInMonth;
                        break;
                }
                ColorField();
            }
            else
            {
                ClearFields();
                listViewSalary.Items.Clear();
                groupBoxChange.Enabled = false;
            }
            */
        }

        /// <summary>
        /// Проверка на вводимые символы для поля Имя, Отчество.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                string bigFirstLetter = e.KeyChar.ToString().ToUpper();
                e.KeyChar = bigFirstLetter[0];
            }

            if ((e.KeyChar >= 'A' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar == '\b'))
                return;

            if (e.KeyChar == (char)Keys.Enter) // нажата клавиша <Enter>
            {
                SendKeys.SendWait("{Tab}");
            }
            e.Handled = true;
        }

        /// <summary>
        /// Проверка на вводимые символы для поля Фамилия, Поиск.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                string bigFirstLetter = e.KeyChar.ToString().ToUpper();
                e.KeyChar = bigFirstLetter[0];
            }

            if ((e.KeyChar >= 'A' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar == '\b'))
                return;

            if (e.KeyChar == '-')
            {
                if ((tb.Text.IndexOf('-') != -1) || (tb.Text.Length == 0)) // уже есть '-'
                    e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter) // нажата клавиша <Enter>
            {
                SendKeys.SendWait("{Tab}");
            }

            e.Handled = true;
        }

        /// <summary>
        /// Проверка на пустые поля, и преобразование регистров для поля Имя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            tb.Text = tb.Text.ToLower();
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Salmon;
            }
            else
            {
                System.Globalization.TextInfo ti = new System.Globalization.CultureInfo("ru-RU", false).TextInfo;
                tb.Text = ti.ToTitleCase(tb.Text);

                tb.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Проверка на пустые поля, и преобразование регистров для поля Отчество.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPatronymic_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            tb.Text = tb.Text.ToLower();
            System.Globalization.TextInfo ti = new System.Globalization.CultureInfo("ru-RU", false).TextInfo;
            tb.Text = ti.ToTitleCase(tb.Text);
        }

        /// <summary>
        /// Проверка на пустые поля, преобразование регистров и проверка на дефиз в конце для поля Фамилия, Поиск.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSurname_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            tb.Text = tb.Text.ToLower();
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Salmon;
            }
            else
            {
                System.Globalization.TextInfo ti = new System.Globalization.CultureInfo("ru-RU", false).TextInfo;
                tb.Text = ti.ToTitleCase(tb.Text);

                tb.BackColor = SystemColors.Window;

            }

            if (tb.Text.IndexOf('-') == (tb.Text.Length - 1))
            {
                tb.BackColor = Color.Salmon;
            }
        }

        /// <summary>
        /// Окрашивание поля в нейтральный цвет при выделении.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Enter(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            tb.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Поиск сотрудников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFind_TextChanged_1(object sender, EventArgs e)
        {
            ClearFields();
            if (textBoxFind.Text != "")
            {
                //List<IEmployer> FindWorker =
               //     ListEmplployee.FindAll(tWorker => tWorker.Surname.StartsWith(textBoxFind.Text));
                listViewWorkers.Items.Clear();
                /*
                foreach (var p in FindWorker)
                {
                    AddListItem(p);
                }
                */
            }
            else
            {
                ConstructListView();
            }
        }

        /// <summary>
        /// Загрука настроек, и последней использованной бызы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkersBase_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\База сотрудников"))
                Directory.CreateDirectory(path + "\\База сотрудников");
            if (!File.Exists(path + "\\База сотрудников\\settings.xml")) //Проверка на наличие файла настроек
            {
                var xWriter = new XmlTextWriter(path + "\\База сотрудников\\settings.xml", Encoding.UTF8);
                xWriter.WriteStartElement("Настройки");
                xWriter.WriteEndElement();
                xWriter.Close();
                var xSettingsNew = new XmlDocument();
                xSettingsNew.Load(path + "\\База сотрудников\\settings.xml");
                XmlNode xPath = xSettingsNew.CreateElement("FilePath");
                xPath.InnerText = "Новый";
                xSettingsNew.DocumentElement.AppendChild(xPath);
                xSettingsNew.Save(path + "\\База сотрудников\\settings.xml");
            }
            var xSettings = new XmlDocument();
            xSettings.Load(path + "\\База сотрудников\\settings.xml");
            foreach (XmlNode xSetNode in xSettings.SelectNodes("Настройки"))
            {
                filePath = xSetNode.SelectSingleNode("FilePath").InnerText;
            }

            if (!File.Exists(filePath))
            {
                newToolStripMenuItem_Click_1(null, null);
                return;
            }
            // OpenXml();
        }

        /// <summary>
        /// Загрузка данных через окно выбора файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialogOpen_FileOk_1(object sender, CancelEventArgs e)
        {
            filePath = openFileDialogOpen.FileName;
            Text = filePath + formName;
            listViewWorkers.Items.Clear();
            // ListEmplployee.Clear();
            listViewSalary.Items.Clear();
            // IndexEmplployee.Clear();
            ClearFields();
            groupBoxChange.Enabled = false;
           //  OpenXml();
        }

        /// <summary>
        /// Запрос при выходе и запись настроек.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkersBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (saveChangesBox()) e.Cancel = true;

            var xSettings = new XmlDocument();
            xSettings.Load(path + "\\База сотрудников\\settings.xml");
            xSettings.CreateElement("Настройки");
            XmlNode xSetNode = xSettings.SelectSingleNode("Настройки");
            xSetNode.RemoveAll();
            XmlNode xPath = xSettings.CreateElement("FilePath");
            xPath.InnerText = filePath;
            xSettings.DocumentElement.AppendChild(xPath);
            xSettings.Save(path + "\\База сотрудников\\settings.xml");
        }
        /// <summary>
        /// Вызов окна открытия файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialogOpen.ShowDialog();
        }

        /// <summary>
        /// Сохранение данных в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //SaveChanges();
            const string message = "Сохранить изменения?";
            const string caption = "Сохранить";
            const MessageBoxButtons YNC = MessageBoxButtons.YesNoCancel;

            DialogResult result = MessageBox.Show(message, caption, YNC);

            return;
        }

        /// <summary>
        /// Создание нового файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveChangesBox()) return; //при нажатии Отмена, отменить действие

            filePath = "Новая";
            Text = filePath + formName;
            listViewWorkers.Items.Clear();
            listViewSalary.Items.Clear();
            // ListEmplployee.Clear();
            ClearFields();
            groupBoxChange.Enabled = false;
        }
        /// <summary>
        /// Окно сохранить как.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// Сохранение в файл, после выбора файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialog_FileOk_1(object sender, CancelEventArgs e)
        {
            filePath = saveFileDialog.FileName;
            Text = filePath + formName;
            // SaveChanges();
        }

        /// <summary>
        /// Выход из меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Удаление записей выдачи зарплаты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (listViewWorkers.SelectedItems.Count != 0)
            {
                ListViewItem i = listViewWorkers.SelectedItems[0];
               IEmployer dictonaryValue;

                string key = i.SubItems[0].Text;
                key += i.SubItems[1].Text;
                key += i.SubItems[2].Text;
                
                if (IndexEmplployee.TryGetValue(key, out dictonaryValue))
                    foreach (ListViewItem j in listViewSalary.SelectedItems)
                    {
                        dictonaryValue.ListSalary.RemoveAt(j.Index);
                        j.Remove();
                    }
                changes = true;
            }
        }

        /// <summary>
        /// Удаление записи.
        /// </summary>
        private void Remove()
        {
            foreach (ListViewItem i in listViewWorkers.SelectedItems)
            {
               // IEmployer dictonaryValue;

                string key = i.SubItems[0].Text;
                key += i.SubItems[1].Text;
                key += i.SubItems[2].Text;
                /*
                if (IndexEmplployee.TryGetValue(key, out dictonaryValue))
                    ListEmplployee.Remove(dictonaryValue);
                IndexEmplployee.Remove(key);
                */
                i.Remove();
            }
        }

        /// <summary>
        /// Окрашивание полей.
        /// </summary>
        private void ColorField()
        {
            textBoxName.BackColor = textBoxName.Text.Length == 0 ? Color.Salmon : SystemColors.Window;
            if (textBoxSurname.Text.IndexOf('-') == (textBoxSurname.Text.Length - 1) ||
                textBoxSurname.Text.Length == 0)
                textBoxSurname.BackColor = Color.Salmon;
            else
                textBoxSurname.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Окрашивание полей для формы добавить.
        /// </summary>
        private void ColorFieldFormAdd()
        {
            form2.textBoxName.BackColor = form2.textBoxName.Text.Length == 0 ? Color.Salmon : SystemColors.Window;
            if (form2.textBoxSurname.Text.IndexOf('-') == (form2.textBoxSurname.Text.Length - 1) ||
                form2.textBoxSurname.Text.Length == 0)
                form2.textBoxSurname.BackColor = Color.Salmon;
            else
                form2.textBoxSurname.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Проверка на корректный ввод полей.
        /// </summary>
        /// <returns></returns>
        private bool NotEmptyFields()
        {
            return (textBoxName.Text.Length != 0) &&
                   (textBoxSurname.Text.Length != 0) &&
                   (textBoxSurname.Text.IndexOf('-') != (textBoxSurname.Text.Length - 1));
        }
        /// <summary>
        /// Проверка на корректный ввод полей для формы добавить.
        /// </summary>
        /// <returns></returns>
        private bool NotEmptyFieldsFormAdd()
        {
            return (form2.textBoxName.Text.Length != 0) &&
                   (form2.textBoxSurname.Text.Length != 0) &&
                   (form2.textBoxSurname.Text.IndexOf('-') != (form2.textBoxSurname.Text.Length - 1));
        }

        /// <summary>
        /// Очищение полей ввода.
        /// </summary>
        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxPatronymic.Text = "";
            numericUpDownHourInMonth.Value = 0;
            numericUpDownPayPerHour.Value = 0;
            numericUpDownPayPerMonth.Value = 0;
            dateTimePickerDateBirthday.Value = DateTime.Now;
        }

        /// <summary>
        /// Очищение полей ввода для формы добавить.
        /// </summary>
        private void ClearFieldsFormAdd()
        {
            form2.textBoxName.Text = "";
            form2.textBoxSurname.Text = "";
            form2.textBoxPatronymic.Text = "";
            form2.numericUpDownHourInMonth.Value = 0;
            form2.numericUpDownPayPerHour.Value = 0;
            form2.numericUpDownPayPerMonth.Value = 0;
            form2.dateTimePickerDateBirthday.Value = DateTime.Now;
        }

        /// <summary>
        /// Добавление элемента в список
        /// </summary>
        /// <param name="p"></param>
        private void AddListItem(IEmployer p)
        {
            var it = new ListViewItem(p.Surname);
            it.SubItems.Add(p.Name);
            it.SubItems.Add(p.DateBirthday.ToShortDateString());
            listViewWorkers.Items.Add(it);
        }

        /// <summary>
        /// Показать записи работников в Поиск.
        /// </summary>
        private void ConstructListView()
        {
            listViewWorkers.Items.Clear();
            /*
            foreach (var p in ListEmplployee)
            {
                AddListItem(p);
            }
            */
        }


        
        /// <summary>
        /// Окно сохранить: да, нет, отмена.
        /// </summary>
        /// <returns></returns>
        private bool saveChangesBox()
        {
            if (changes == false) return false;

            const string message = "Сохранить изменения?";
            const string caption = "Сохранить";
            const MessageBoxButtons YNC = MessageBoxButtons.YesNoCancel;

            DialogResult result = MessageBox.Show(message, caption, YNC);

            switch (result)
            {
                case (DialogResult.Yes):
                    //SaveChanges();
                    return false;

                case (DialogResult.No):
                    return false;

                case (DialogResult.Cancel):
                    return true;
                default:
                    return true;
            }
        }

        /// <summary>
        /// Ограничение на англиский язык.
        /// </summary>
        /// <returns></returns>
        private void textBoxSurname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Ограничение на отрицательные числа.
        /// </summary>
        /// <returns></returns>
        private void numericUpDownPayPerHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void numericUpDownHourInMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void numericUpDownPayPerMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
  }

