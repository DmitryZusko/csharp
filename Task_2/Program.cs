/* Визначити і надрукувати номери і значення двох чисел Фібоначі, в проміжок між якими потрапляє введене з клавіатури натуральне число. */

using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a natural number: ");
            var userNum = Convert.ToInt32(Console.ReadLine());
            var fibCounter = 0;
            var getFib = 0;

            /* Рахуємо числа Фібоначі до тих пір, поки наше число не стане більше, ніж число користувача. fib_counter дасть нам номер Фібоначі, більшого за число юзера */
            while (getFib <= userNum)
            {
                fibCounter++;
                getFib = Figiovanna(fibCounter);
            }

            /* При цьому, якшо юзер ввів число Фібоначі, то найближче знизу буде мати номер (fib_counter - 2). Якщо ж user_num != числу Фібоначі, то найближче знизу матиме номер (fib_counter - 2) */
            if (Figiovanna(fibCounter - 1) == userNum)
            // В System.Linq є метод Equals. Треба було його в if-виразі юзати? Якшо да, то чого звичайне == гірше?
            {
                Console.WriteLine($"Upper Fibonacci number is: {Figiovanna(fibCounter)}. Lower Fibonacci number is: {Figiovanna(fibCounter - 2)}.");
            }
            else
            {
                Console.WriteLine($"Upper Fibonacci number is: {Figiovanna(fibCounter)}. Lower Fibonacci number is: {Figiovanna(fibCounter - 1)}.");
            }


            Console.ReadLine();
        }

        /* Метод для обрахунку ряду Фібоначі */
        static int Figiovanna(int n)
        {
            if (n == 0 || n == 1) return n;

            return Figiovanna(n - 1) + Figiovanna(n - 2);

        }
    }
}
