/* За заданим восьмизначним натуральним числом знаходить середнє арифметичне цифр цього числа та кількість ненульових цифр. */

using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter eight-digit natural number: ");
            var userNum = Console.ReadLine();
            var numbers = userNum.ToList().Select(ch => int.Parse(ch.ToString()));
            var counter = numbers.Where(n => n != 0).Count();
            var numAverage = numbers.Average();

            Console.WriteLine($"Number is {userNum}. \n Avarage is {numAverage}. \n Non-zero numbers: {counter}.");

            Console.ReadLine();
        }
    }
}
