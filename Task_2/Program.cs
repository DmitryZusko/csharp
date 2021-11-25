/* Визначити і надрукувати номери і значення двох чисел Фібоначі, в проміжок між якими потрапляє введене з клавіатури натуральне число. */

using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a natural number: ");
            var userNum = Convert.ToInt32(Console.ReadLine());
            var fibCounter = 0;
            var fibMax = 0;
            var fibMiddle = 0;
            var fibLow = 0;

            /* Рахуємо числа Фібоначі до тих пір, поки наше число не стане більше, ніж число користувача. fib_counter дасть нам номер Фібоначі, більшого за число юзера */
            while (fibMax <= userNum)
            {
                fibCounter++;
                fibLow = fibMiddle;
                fibMiddle = fibMax;
                fibMax = Figiovanna(fibCounter);
            }

            /* на всякий випадок поясню, чого треба три змінні зберігати, а не дві, як ти казав (мені прост здалось, шо ти не викупив). 
             * Припустим, в змінних ми зберігаємо лише актуальний і попередній обрахунок. Таким чином, якшо юзер передасть в userNum число Фібоначчі (наприклад, 5), то ми отримаємо такий ряд обрахунків:
             * 1 1 2 3 5 8 13. При цьому збереженими будуть тільки 13 і 8. Як результат, ми отримаємо на виході: максимальне число = 13, а мінімальне = 8, хоча мінімальне повинно бути 5!
             * Для цього ми повинні зберігати 3 останні цифри і для цього при виводі тренарний оператор і виконує перевірку*/

            Console.WriteLine($"Upper Fibonacci number is: {fibMax}. Lower Fibonacci number is: {(fibMiddle == userNum ? fibLow : fibMiddle)}.");

            Console.ReadLine();
        }

        /* Метод для обрахунку ряду Фібоначі */
            static int Figiovanna(int n)
        {
            if (n <= 1) 
            {
                return n;
            }

            return Figiovanna(n - 1) + Figiovanna(n - 2);

        }
    }
}
