using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_10
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInformation information = new EmployeeInformation();

            Random random = new Random();

            Employee[] employees = new Employee[]
            {
                new Employee("Dilnaz Yerik", Vacancy.Boss, random.Next(), new DateTime(2019, 03, 21)),

                new Employee("Mark Elliot Zuckerberg", Vacancy.Clerk, random.Next(), new DateTime(2015, 09, 19)),

                new Employee("Yerik Asanali", Vacancy.Manager, random.Next(), new DateTime(2001, 03, 29)),

                new Employee("Elizabeth Olsen", Vacancy.Salesman, random.Next(), new DateTime(2019, 10, 06)),
            };

            information.AllEmployeeInformation(employees);
            information.AverageSalary(employees);
            Console.WriteLine("\n\nСотрудники которые были приняты после Босса");
            Console.WriteLine();
            information.DateOfEmploymentAfterTheBoss(employees);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
