using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_10_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MINIMUM = 0;

            const int MAXIMUM_MARK = 101;

            const int MAXIMUM_INCOME = 150000;

            const int MINIMUM_SALARY = 15000;

            Random random = new Random();

            List<Student> hostel = new List<Student>();

            Student[] students = new Student[]
            {
                new Student("Тихов Кирил Олегович", "SDB", random.Next(MINIMUM, MAXIMUM_MARK) , random.Next(MINIMUM, MAXIMUM_INCOME) , Gender.Male, FormOfEducation.Intramural),
                new Student("Айымбетова Енлик  Адильжанова", "DDN", random.Next(MINIMUM, MAXIMUM_MARK) , random.Next(MINIMUM, MAXIMUM_INCOME) , Gender.Female, FormOfEducation.ExternalStudy),
                new Student("Соловьев Дмитрий Потанович", "PND", random.Next(MINIMUM, MAXIMUM_MARK) , random.Next(MINIMUM, MAXIMUM_INCOME) , Gender.Male, FormOfEducation.Correspondence)
            };


            foreach (Student student in students)
            {
                student.ShowInforformationStudent();
            }

            foreach (Student student in students)
            {
                if (student.IncomeFamily < MINIMUM_SALARY + MINIMUM_SALARY)
                {
                    hostel.Add(student);
                }
            }

            hostel.Sort(StudentAverageMarkComparer);

            foreach (Student student in students)
            {
                if (student.IncomeFamily >= MINIMUM_SALARY + MINIMUM_SALARY)
                {
                    hostel.Add(student);
                }
            }


            Console.WriteLine("\n\nПорядок заселения студентов в общежитиие: ");
            Console.WriteLine();


            foreach (Student student in hostel)
            {
                student.ShowInforformationStudent();
            }

            Console.ReadKey();
        }

        static int StudentAverageMarkComparer(Student firstStudent, Student secondStudent)
        {

            if (firstStudent.AverageMark < secondStudent.AverageMark)
            {
                return 1;
            }

            else if (firstStudent.AverageMark > secondStudent.AverageMark)
            {
                return -1;
            }

            return 0;
        }
    }
}
