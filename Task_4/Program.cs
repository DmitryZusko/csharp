/*4. Звичайний консольний застосунок. Вважаючи, що введене речення з клавіатури складається з довільної кількості слів, між якими є довільна кількість пробілів, 
 * і закінчується речення крапкою, написати програму для розв’язання завдання: Визначити відсоток вживання у введеному реченні кожної з голосних літер. 
 * Результат записати в спадному порядку.*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your goddamn sentence: ");
            var userSent = Console.ReadLine();
            var clearUserSent = String.Concat(Regex.Split(userSent, @"\W|\d"));
            var vowelLetters = "aeyuio";
            var vowelcount = new Dictionary<char, int>();

            foreach (var vowel in vowelLetters)
            {
                int count = Regex.Matches(clearUserSent, vowel.ToString()).Count();
                vowelcount.Add(vowel, 100 * count / clearUserSent.Length);
            }
            /* рахуємо кількість повіторів для голосних і закидаємо в словник, де ключ - літера, значення - відсоток вживання. */

            foreach (var pair in vowelcount.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine($"vowel {pair.Key} occupies {pair.Value}%.");
            }

            Console.ReadLine();
        }
    }
}
