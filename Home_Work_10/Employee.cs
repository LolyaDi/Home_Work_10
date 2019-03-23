using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_10
{
    public struct Employee
    {
        public string Name { get; set; }

        public Vacancy Vacancy { get; set; }

        public int Salary { get; set; }

        public DateTime DateOfEmployment { get; set; }

        public Employee(string name, Vacancy vacancy, int salary, DateTime dateOfEmployment)
        {
            Name = name;

            Vacancy = vacancy;

            Salary = salary;

            DateOfEmployment = dateOfEmployment;
        }
    }
}
