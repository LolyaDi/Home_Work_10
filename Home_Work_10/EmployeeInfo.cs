using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_10
{
    public class EmployeeInformation
    {

        public void AllEmployeeInformation(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"\nИмя сотрудника: {employee.Name}");
                Console.WriteLine($"\nЗарпалата сотрудника: {employee.Salary}$");
                Console.WriteLine($"\nВакансия сотрудника: {employee.Vacancy}");
                Console.WriteLine($"\nДата приема на работу сотрудника: {employee.DateOfEmployment}");
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }

        public void AverageSalary(Employee[] employees)
        {
            const int NULL = 0;
            double clerkSalary = NULL;
            double clerkAverageSalary;
            int countClerk = NULL;

            foreach (Employee employee in employees)
            {
                if (employee.Vacancy == Vacancy.Clerk)
                {
                    clerkSalary += employee.Salary;
                    countClerk++;
                }
            }

            clerkAverageSalary = clerkSalary / countClerk;


            Console.WriteLine($"Зарпалата менеджеров, чья зарплата больше средней зарплаты всех клерков");
            Employee manager = new Employee();

            foreach (Employee employee in employees)
            {
                if (employee.Vacancy == Vacancy.Manager && employee.Salary > clerkAverageSalary)
                {
                    manager = employee;
                    Console.WriteLine($"\nИмя: {manager.Name}");
                    Console.WriteLine($"\nДолжность: {manager.Vacancy}");
                    Console.WriteLine($"\nЗарплата: {manager.Salary}");
                }
            }

        }

        public void DateOfEmploymentAfterTheBoss(Employee[] employees)
        {
            Employee boss = new Employee();


            foreach (Employee employee in employees)
            {
                if (employee.Vacancy == Vacancy.Boss)
                {
                    boss = employee;
                    break;
                }
            }

            foreach (Employee employee in employees)
            {
                if (employee.DateOfEmployment > boss.DateOfEmployment)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"\nИмя: {employee.Name}");
                    Console.WriteLine($"\nВакансия: {employee.Vacancy}");
                    Console.WriteLine($"\nЗарплата: {employee.Salary}");
                    Console.WriteLine($"\nДата принятия на работу: {employee.DateOfEmployment}");
                }
            }

        }
    }
}
