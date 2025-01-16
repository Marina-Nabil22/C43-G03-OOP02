using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum SecurityPrivileges
{
    guest,
    Developer,
    secretary,
    DBA
}
namespace OOP02
{
    #region Q1

    public class Employee : IComparable<Employee>
    {
        private int Id { set; get; }
        private string Name { set; get; }
        private SecurityPrivileges SecurityLevel { set; get; }
        private decimal Salary { set; get; }
        private HireDate hireDate { set; get; }
        private char gender;
        private char Gender
        {
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    Console.WriteLine("Enter onle M or F");

            }
            get { return gender; }



        }

        public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, HireDate _hireDate, char gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            hireDate = _hireDate;
            Gender = gender;

        }

        public override string ToString()
        {
            return $"EmpId ={Id} , EmpName={Name} , SecurityLevel={SecurityLevel} , Salary={Salary} , Hire Date={hireDate} , Gender={gender}\n";
        }
        public string DisplaySalary(string salary)
        {
            return string.Format("0:C", salary);
        }

        public int CompareTo(Employee emp)
        {

            if (this.hireDate.Year != emp.hireDate.Year)
                return this.hireDate.Year.CompareTo(emp.hireDate.Year);
            if (this.hireDate.Month != emp.hireDate.Month)
                return this.hireDate.Month.CompareTo(emp.hireDate.Month);
            return this.hireDate.Day.CompareTo(emp.hireDate.Day);
        }


    }

    #endregion
}   
