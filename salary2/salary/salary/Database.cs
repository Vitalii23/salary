using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace salary
{
    public class Database

    {
        // public List<IEmployer> employers = new List<IEmployer> ();
        private Dictionary<string, IEmployer> IndexEmployers = new Dictionary<string, IEmployer>();
        private List<Action<IEmployer>> EventsAdd = new List<Action<IEmployer>> ();
        private List<Action> EventsFlush = new List<Action> ();

        // private bool changes;
        // private string filePath;
        // private const string formName = " - База сотрудника";

        /// <summary>
        /// Загрузка данных из xml.
        /// </summary>
        public void loadfile(string filename)
        {
            flush();
            var xDoc = new XmlDocument();
           
            try
            {
                xDoc.Load(filename);
            }
            catch (System.Xml.XmlException)
            {
                MessageBox.Show("Ошибка чтиния файла", "Ошибка");
            }

            int errCount = 0;

            foreach (XmlNode xNode in xDoc.SelectNodes("Сотрудник/Человек"))
            {
                try
                {
                    var employer = loadEmployer(xNode);

                    employer.Surname = xNode.SelectSingleNode("Фамилия").InnerText;
                    employer.Name = xNode.SelectSingleNode("Имя").InnerText;
                    employer.Patronymic = xNode.SelectSingleNode("Отчество").InnerText;
                    employer.DateBirthday = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("DateBirtday").InnerText));
                    employer.Type = TypePayment.HourPay;
                    employer.ListSalary = new List<Salary>();

                    var xSalary = xNode.SelectSingleNode("Зарплата");
                    var countPay = xSalary.ChildNodes.Count;
                    for (int i = 0; i < countPay; i++)
                    {
                        Salary a = new Salary();
                        try
                        {
                            a.Amount = Convert.ToDecimal(xSalary.SelectSingleNode("Плата" + i + "/Количество").InnerText);
                            a.DateSalary = DateTime.FromFileTime(
                                Convert.ToInt64(xSalary.SelectSingleNode("Плата" + i + "/Дата зарплаты").InnerText));
                            employer.ListSalary.Add(a);
                        }
                        catch (FormatException)
                        {
                            continue;
                        }
                    }

                    string listKey = employer.Surname + employer.Name + employer.DateBirthday.ToShortDateString();
                    add(listKey, employer);
                }
                catch
                {
                    errCount++;
                }

                if (errCount != 0)
                {
                    string message = "Количество поврежденных сотрудников " + errCount;
                    MessageBox.Show(message, "Внимание");
                }
            }
        }

        void add(String listKey, IEmployer employer)
        {
            IndexEmployers.Add(listKey, employer);
            EventsAdd.ForEach(cb => cb(employer));
        }

        public void flush()
        {
            IndexEmployers.Clear();
            EventsFlush.ForEach(cb => cb());
        }

        protected Boolean checkNode(XmlNode xNode)
        {
            if (validateSurname(xNode.SelectSingleNode("Имя").InnerText))
            {
                return false;
            }
            if (validateName(xNode.SelectSingleNode("Фамилия").InnerText))
            {
                return false;
            }
            if (validatePatronymic(xNode.SelectSingleNode("Отчество").InnerText))
            {
                return false;
            }
            return true;
        }

        IEmployer loadEmployer(XmlNode xNode)
        {
            if (!checkNode(xNode))
            {
                throw new Exception("asd");
            }

            if (xNode.SelectSingleNode("Тип").InnerText == TypePayment.MonthPay.ToString())
            {
                return loadMonthEmployer(xNode);
            }
            if (xNode.SelectSingleNode("Тип").InnerText == TypePayment.MonthPay.ToString())
            {
                return loadHourEmployer(xNode);
            }

            return null;
        }

        protected EmployerMonth loadMonthEmployer (XmlNode xNode)
        {
            EmployerMonth employer = new EmployerMonth();
            employer.PayPerMonth = Convert.ToDecimal(xNode.SelectSingleNode("Месячная").InnerText);
            employer.Type = TypePayment.MonthPay;


            return employer;
        }
        protected EmployerHour loadHourEmployer(XmlNode xNode)
        {
            EmployerHour employer = new EmployerHour();
            employer.HourInMonth = Convert.ToDecimal(xNode.SelectSingleNode("Почасовая").InnerText);
            employer.PayPerHour = Convert.ToDecimal(xNode.SelectSingleNode("Месячная").InnerText);
            employer.Type = TypePayment.HourPay;

            
            return employer;
        }

        private bool validateName(string value)
        {
            string pattern = @"^[А-ЯA-Z]{1}[а-яa-z]{0,14}$";
            Match match = Regex.Match(value, pattern);
            return match.Success;
        }

        /// <summary>
        /// Проверка фамилии сотрудника при загрузке файла.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool validateSurname(string value)
        {
            string pattern = @"^[А-ЯA-Z][а-яa-z]{0,18}-[А-ЯA-Z][а-яa-z]{0,18}$|^[А-ЯA-Z]{1}[а-яa-z]{0,19}$";
            Match match = Regex.Match(value, pattern);
            return match.Success;
        }

        /// <summary>
        /// Проверка отчества сотрудника при загрузке файла.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool validatePatronymic(string value)
        {
            if (value == "")
                return false;
            string pattern = @"^[А-ЯA-Z]{1}[а-яa-z]{0,24}$";
            Match match = Regex.Match(value, pattern);
            return match.Success;
        }
        /// <summary>


        public void savefile(string filename)
        {
            var xDoc = new XmlDocument();
            var xW = new XmlTextWriter(filename, Encoding.UTF8);
            xW.WriteStartElement("Сотрудники");
            xW.WriteEndElement();
            xW.Close();
            xDoc.Load(filename);
            xDoc.CreateElement("Сотрудники");
            XmlNode xNode = xDoc.SelectSingleNode("Сотрудники");
            xNode.RemoveAll();

            foreach (KeyValuePair<string, IEmployer> entry in IndexEmployers)
            {
                // do something with entry.Value or entry.Key
                if (entry.Value.Type == TypePayment.MonthPay)
                {
                    saveMonthEmployer(xDoc, (EmployerMonth)entry.Value);
                }
                if (entry.Value.Type == TypePayment.HourPay)
                {
                    saveHourEmployer(xDoc, (EmployerHour)entry.Value);
                }
            }
            xDoc.Save(filename);
        }

        private void saveMonthEmployer(XmlDocument xDoc, EmployerMonth employer)
        {
            XmlNode xPayPerMonth = xDoc.CreateElement("Месячная");
            xPayPerMonth.InnerText = employer.PayPerMonth.ToString();

            XmlNode xTop = xDoc.CreateElement("Человек");
            XmlNode xSurname = xDoc.CreateElement("Фамилия");
            XmlNode xName = xDoc.CreateElement("Имя");
            XmlNode xPatronymic = xDoc.CreateElement("Отчество");
            XmlNode xDateBirtday = xDoc.CreateElement("Дата_рождения");
            XmlNode xType = xDoc.CreateElement("Тип");
            XmlNode xSalary = xDoc.CreateElement("Зарплата");

            int j = 0;
            foreach (Salary i in employer.ListSalary)
            {
                XmlNode xPay = xDoc.CreateElement("Плата" + j);
                XmlNode xDataPay = xDoc.CreateElement("Дата_зарплаты");
                XmlNode xAmount = xDoc.CreateElement("Количество");
                xDataPay.InnerText = i.DateSalary.ToFileTime().ToString();
                xAmount.InnerText = i.Amount.ToString();
                xPay.AppendChild(xDataPay);
                xPay.AppendChild(xAmount);
                xSalary.AppendChild(xPay);
                j++;
            }
            xSurname.InnerText = employer.Surname;
            xName.InnerText = employer.Name;
            xPatronymic.InnerText = employer.Patronymic;
            xDateBirtday.InnerText = employer.DateBirthday.ToFileTime().ToString();
            xType.InnerText = employer.Type.ToString();
            xTop.AppendChild(xSurname);
            xTop.AppendChild(xName);
            xTop.AppendChild(xPatronymic);
            xTop.AppendChild(xDateBirtday);
            xTop.AppendChild(xType);
            xTop.AppendChild(xSalary);

            xTop.AppendChild(xPayPerMonth);
            xDoc.DocumentElement.AppendChild(xTop);
        }

        private void saveHourEmployer(XmlDocument xDoc, EmployerHour employer)
        {
            XmlNode xHourInMonth = xDoc.CreateElement("Проработанные_часы");
            XmlNode xPayPerHout = xDoc.CreateElement("Почасовая");
            xHourInMonth.InnerText = employer.HourInMonth.ToString();
            xPayPerHout.InnerText = employer.HourInMonth.ToString();

            XmlNode xTop = xDoc.CreateElement("Человек");
            XmlNode xSurname = xDoc.CreateElement("Фамилия");
            XmlNode xName = xDoc.CreateElement("Имя");
            XmlNode xPatronymic = xDoc.CreateElement("Отчество");
            XmlNode xDateBirtday = xDoc.CreateElement("Дата_рождения");
            XmlNode xType = xDoc.CreateElement("Тип");
            XmlNode xSalary = xDoc.CreateElement("Плата");

            int j = 0;
            foreach (Salary i in employer.ListSalary)
            {
                XmlNode xPay = xDoc.CreateElement("Плата" + j);
                XmlNode xDataPay = xDoc.CreateElement("Дата_зарплаты");
                XmlNode xAmount = xDoc.CreateElement("Количество");
                xDataPay.InnerText = i.DateSalary.ToFileTime().ToString();
                xAmount.InnerText = i.Amount.ToString();
                xPay.AppendChild(xDataPay);
                xPay.AppendChild(xAmount);
                xSalary.AppendChild(xPay);
                j++;
            }
            xSurname.InnerText = employer.Surname;
            xName.InnerText = employer.Name;
            xPatronymic.InnerText = employer.Patronymic;
            xDateBirtday.InnerText = employer.DateBirthday.ToFileTime().ToString();
            xType.InnerText = employer.Type.ToString();
            xTop.AppendChild(xSurname);
            xTop.AppendChild(xName);
            xTop.AppendChild(xPatronymic);
            xTop.AppendChild(xDateBirtday);
            xTop.AppendChild(xType);
            xTop.AppendChild(xSalary);

            xTop.AppendChild(xHourInMonth);
            xTop.AppendChild(xPayPerHout);
            xDoc.DocumentElement.AppendChild(xTop);
        }

        private void AddOwnedForm(Form form)
        {
            throw new NotImplementedException();
        }

        public void onAdd(Action<IEmployer> cb)
        {
            EventsAdd.Add(cb);
        }
        public void onFlush(Action cb)
        {
            EventsFlush.Add(cb);
        }

    }
}