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
        private static int stCount;
        private static int stMaxMarkCount;

        public Student(string lastName, string FirstName, string Birthday, double AverageMark)
        {
            _lastName = lastName;
            _firstName = FirstName;
            _birthday = DateTime.Parse(Birthday);
            _averageMark = AverageMark;
            stCount++;
            if (_averageMark == 5.0) stMaxMarkCount++;

        }

        private void Print()
        {
            Console.WriteLine($"{_lastName} \t {_firstName} \t {_birthday} \t {_averageMark}");
        }

        static public void PrintAllStudents(List<Student> stList)
        {
            foreach (Student student in stList)
                student.Print();
        }


        private static Student[] SortByBirthday(Student[] arr)
        {
            for (var i = 1; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - i; j++)
                {

                    if (DateTime.Compare(arr[j]._birthday, arr[j+1]._birthday) > 0)
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }

                }
            }

            return arr;
        }

        public static void GetMaxAndSort(List<Student> stList)
        {
            List<Student> bestStudents = new List<Student>();

            foreach (Student student in stList)
            {
                if (student._averageMark == 5.0)
                    bestStudents.Add(student);
            }

            Student[] sortBestSt = Student.SortByBirthday(bestStudents.ToArray());
            Student.PrintAllStudents(sortBestSt.ToList());
        }

    }
}
