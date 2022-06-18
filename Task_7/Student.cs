using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_7
{
    class Student
    {
        private string _lastName;
        private string _firstName;
        private DateTime _birthday;
        private double _averageMark;

        public Student(string lastName, string FirstName, string Birthday, double AverageMark)
        {
            _lastName = lastName;
            _firstName = FirstName;
            _birthday = DateTime.Parse(Birthday);
            _averageMark = AverageMark;

        }

        private void Print()
        {
            Console.WriteLine($"{_lastName} \t {_firstName} \t {_birthday.ToShortDateString()} \t {_averageMark}");
        }

        static public void PrintAllStudents(List<Student> stList)
        {
            foreach (Student student in stList)
                student.Print();
        }

        public static void GetMaxAndSort(List<Student> stList)
        {
            List<Student> bestStudents = new List<Student>();

            Student[] sortedBestSt = stList.Where(student => student._averageMark >= 5.0).OrderBy(student => student._birthday).ToArray();
            Student.PrintAllStudents(sortedBestSt.ToList());
        }

    }
}
