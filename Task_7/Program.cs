/* 7.Звичайний консольний застосунок.З текстового файлу зчитати послідовність записів, які містять дані про результати сесії студентів групи у такому форматі: 
 * <Прізвище>, <Ім’я>, <Дата народження>, <Список екзаменаційних оцінок>. Роздрукувати введені дані у вигляді таблиці, а також роздрукувати список студентів, 
 * які отримали лише оцінки 5 на іспитах, у зростаючому порядку за віком */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;



namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jonathan = new Student("Joestar", "Jonathan", "04.04.1868", 5.0);
            var Joseph = new Student("Joestar", "Joseph", "27.09.1920", 5.0);
            var Jotaro = new Student("Kujo", "Jotaro", "03.04.1970", 5.0);
            var Josuke = new Student("Higashikata", "Josuke", "20.05.1983", 5.0);
            var Giorno = new Student("Giovanna", "Giorno", "16.04.1985", 5.0);
            var Jolyne = new Student("Kujo", "Jolyne", "15.12.1992", 5.0);
            var Johnny = new Student("Joestar", "Johnny", "10.04.1872", 4.9);
            var Lexa = new Student("Gay-Sailor", "Lexa", "19.08.2011", 4.9);

            var allStudents = new List<Student> { Johnny, Jotaro, Joseph, Jonathan, Josuke, Giorno, Jolyne, Lexa };

            Console.WriteLine("*** Let's see a list of students *** \n");
            Student.PrintAllStudents(allStudents);

            Console.WriteLine("\n *** Now let's find and sort best Jojos *** \n");

            Student.GetMaxAndSort(allStudents);

        }
    }
}
