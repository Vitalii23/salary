using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{


    public enum TypePayment
    {
        MonthPay,
        HourPay
    }
    /// <summary>
    /// Интерфейс класса сотрудника.
    /// </summary>

    public interface IEmployer
    {
        /// <summary>
        /// Тип сотрудника
        /// </summary>
        TypePayment Type { get; set; }

        /// <summary>
        /// Имя сотрудника.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        string Surname { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        string Patronymic { get; set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        DateTime DateBirthday { get; set; }

        /// <summary>
        /// Зарплата.
        /// </summary>
       List<Salary> ListSalary { get; set; }

        /// <summary>
        /// Подсчет зарплаты.
        /// </summary>
        /// <returns></returns>
        decimal CalcMonthPay();
    }
}
