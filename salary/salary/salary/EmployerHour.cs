using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{

    /// <summary>
    ///Оплата за час.
    /// </summary>
    public class EmployerHour : IEmployer
    {
        /// <summary>
        /// Тип работника
        /// </summary>
        public TypePayment Type { get; set; }

        /// <summary>
        /// Имя работника.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime DateBirthday { get; set; }

        /// <summary>
        /// Зарплата.
        /// </summary>
        public List<Salary> ListSalary { get; set; }

        /// <summary>
        /// Сумма оплаты за час.
        /// </summary>
        public decimal PayPerHour { get; set; }

        /// <summary>
        /// Количество отработанных часов в месяц.
        /// </summary>
        public decimal HourInMonth { get; set; }

        /// <summary>
        /// Подсчет месячной зарплаты.
        /// </summary>
        /// <returns></returns>



        public decimal CalcMonthPay()
        {
            return PayPerHour * HourInMonth;
        }
    }
}
