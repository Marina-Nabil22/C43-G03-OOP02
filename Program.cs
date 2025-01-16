using OOP02.Q5;
using System.Runtime.Intrinsics.X86;

namespace OOP02
{
    internal class Program
    {
      
        static void Main(string[] args)
        {

            #region Q3
            HireDate[] hireDates = new HireDate[3];
            hireDates[0] = new HireDate(20, 10, 2000);
            hireDates[1] = new HireDate(21, 9, 2000);
            hireDates[2] = new HireDate(22, 12, 2000);
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "Marina", SecurityPrivileges.DBA, 2000, hireDates[0], 'F');
            EmpArr[1] = new Employee(2, "Mariam", SecurityPrivileges.guest, 3000, hireDates[1], 'F');
            EmpArr[2] = new Employee(3, "Fatma", SecurityPrivileges.Developer, 4000, hireDates[2], 'F');
            //Console.WriteLine("Employees before sorting:");
            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp.ToString());
            //}

            #endregion

            #region Q4
            Array.Sort(EmpArr);

            //Console.WriteLine("\nEmployees after sorting:");
            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp.ToString());
            //}


            #endregion

            #region Q5
            eBook b1 = new eBook(250, "aaa", "bbb", 123);
            b1.dispalyBook();
            PrintedBook b2 = new PrintedBook(30, "ccc", "jjj", 1234);
            b2.dispalyBook();

            Book b3 = new eBook(350, "ooo", "lll", 897);
            b3.dispalyBook();

         
            #endregion
        }




    }
}