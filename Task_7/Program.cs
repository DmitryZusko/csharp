/* 7.Звичайний консольний застосунок.З текстового файлу зчитати послідовність записів, які містять дані про результати сесії студентів групи у такому форматі: 
 * <Прізвище>, <Ім’я>, <Дата народження>, <Список екзаменаційних оцінок>. Роздрукувати введені дані у вигляді таблиці, а також роздрукувати список студентів, 
 * які отримали лише оцінки 5 на іспитах, у зростаючому порядку за віком */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Globalization;



namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentsList = new List<Student>();
            foreach (var line in File.ReadLines("Students.txt"))
            {
                var splitStudent = line.Split(", ");
                studentsList.Add(new Student(splitStudent[0], splitStudent[1], splitStudent[2], double.Parse(splitStudent[3])));
            }


            Console.WriteLine("*** Let's see a list of students *** \n");
            Student.PrintAllStudents(studentsList);

            Console.WriteLine("\n *** Now let's find and sort best Jojos *** \n");

            Student.GetMaxAndSort(studentsList);

        }
    }
}
