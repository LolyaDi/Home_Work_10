using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_10_Task_2
{
    public class Student
    {
        public string FullName { get; set; }

        public string GroupName { get; set; }

        public int AverageMark { get; set; }

        public int IncomeFamily{ get; set; }

        public Gender Gender { get; set; }

        public FormOfEducation FormOfEducationStudent { get; set; }

        public Student(string nameStudent, string groupName, int averageMark, int incomeFamily, Gender gender, FormOfEducation formOfEducation)
        {
            FullName = nameStudent;

            GroupName = groupName;

            AverageMark = averageMark;

            IncomeFamily = incomeFamily;

            Gender = gender;

            FormOfEducationStudent = formOfEducation;
        }

        public void ShowInforformationStudent()
        {
            Console.WriteLine($"\nФИО студента: {FullName}");
            Console.WriteLine($"\nПол: {Gender}");
            Console.WriteLine($"\nГруппа студента: {GroupName}");
            Console.WriteLine($"\nДоход на члена семьи {IncomeFamily}");
            Console.WriteLine($"\nФорма обучения: {FormOfEducationStudent}");
            Console.WriteLine($"\nСредний балл: {AverageMark}");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
