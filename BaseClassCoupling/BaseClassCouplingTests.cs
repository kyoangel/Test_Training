using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BaseClassCoupling
{
    [TestClass]
    public class BaseClassCouplingTests
    {
        /// <summary>
        /// if my monthly salary is 1200, working year is 0.5, my bonus should be 600
        /// </summary>
        [TestMethod]
        public void calculate_half_year_employee_bonus()
        {
            var lessThanOneYearEmployee = new FakeEmployee()
            {
                Id = 91,
                Today = new DateTime(2018, 1, 27),
                StartWorkingDate = new DateTime(2017, 7, 29)
            };
            lessThanOneYearEmployee.Log = new TestConsoleLogAdapter();
            var actual = lessThanOneYearEmployee.GetYearlyBonus();
            Assert.AreEqual(600, actual);
        }
    }

    public class FakeEmployee : LessThanOneYearEmployee
    {
        protected override decimal GetMonthlySalary()
        {
            return 1200;
        }
    }

    public class TestConsoleLogAdapter : ILog
    {
        public void Info(string text)
        {
            Console.WriteLine(text);
        }
    }

    public abstract class Employee
    {
        private ILog _log;
        public DateTime StartWorkingDate { get; set; }
        public DateTime Today { get; set; }

        protected virtual decimal GetMonthlySalary()
        {
            Log.Info($"query monthly salary id:{Id}");
            return SalaryRepo.Get(this.Id);
        }

        public ILog Log
        {
            get
            {
                return _log ?? new DebugHelperLogAdapter();
            }
            set
            {
                _log = value;
            }
        }

        public abstract decimal GetYearlyBonus();

        public int Id { get; set; }
    }

    public interface ILog
    {
        void Info(string text);
    }

    public class DebugHelperLogAdapter : ILog
    {
        public void Info(string text)
        {
            DebugHelper.Info(text);
        }
    }

    public class LessThanOneYearEmployee : Employee
    {
        public override decimal GetYearlyBonus()
        {
            Log.Info("--get yearly bonus--");
            var salary = this.GetMonthlySalary();

            Log.Info($"id:{Id}, his monthly salary is:{salary}");
            return Convert.ToDecimal(this.WorkingYear()) * salary;
        }

        private double WorkingYear()
        {
            Log.Info("--get working year--");
            var year = (Today - StartWorkingDate).TotalDays / 365;
            return year > 1 ? 1 : Math.Round(year, 2);
        }
    }

    public static class DebugHelper
    {
        public static void Info(string message)
        {
            //you can't modified this function
            throw new NotImplementedException();
        }
    }

    public static class SalaryRepo
    {
        internal static decimal Get(int id)
        {
            //you can't modified this function
            throw new NotImplementedException();
        }
    }
}