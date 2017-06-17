using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salary;
using System.Runtime.InteropServices.ComTypes;

namespace UnitTests.model
{
    [TestFixture]
    public class MyClassTest
    {

        [Test]
       [TestCase(12, 1, TestName = "Тестирование Count при присваивании 12,1,")]

        /// [TestCase(5,0, TestName = "Тестирование Count при присваивании 5,0")]
        /// [TestCase(int.MaxValue, TestName = "Тестирование Count при присваивании MaxValue.")]
        /// [TestCase(int.MaxValue - 1, TestName = "Тестирование Count при присваивании MaxValue - 1.")]
        /// [TestCase(-1, ExpectedResult = typeof(ArgumentException), TestName = "Тестирование Count при присваивании - 1.")]
        /// [TestCase(int.MinValue, ExpectedResult = typeof(ArgumentException), TestName = "Тсетирование Count приприсваивании минимально допустимого целого числа.")]
       public void CountTest(decimal count1, decimal count2)
        {
            var EmployerHour = new EmployerHour();
            EmployerHour.PayPerHour = count1;
            EmployerHour.HourInMonth = count2;

        }


        [Test]
        [TestCase("Гитлер", "Адольф", TestName = "Тестирование Count при присваивании Гитлер, Адольф")]
        public void CountTest1(string count3, string count4)
        {
            var EmployerMonth = new EmployerMonth();
            EmployerMonth.Name = count3;
            EmployerMonth.Surname = count4;

        }

    }
}
