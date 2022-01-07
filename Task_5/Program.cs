/*5.Звичайний консольний застосунок.Написати функцію, яка визначає, чи входить до складу заданого символьного рядка вказане користувачем ключове слово.
    На основі розробленої функції визначити, в якому з речень найбільше разів зустрічається заданий ключовий набір символів.*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeDict = new Dictionary<string, int>();

            Console.WriteLine("Enter subsentense: ");
            var subsentence = Console.ReadLine();
            Console.WriteLine("Enter you sentence to proceed or «exit» to shut down the program");
            var sentence = Console.ReadLine();

            while(!sentence.Equals("exit"))
            {
                var count = RepeatsCount(sentence, subsentence);
                Console.WriteLine($"{subsentence} repeats {count} time(-s).");
                storeDict.Add(sentence, count);
                Console.WriteLine("Enter you sentence to proceed or «exit» to shut down the program");
                sentence = Console.ReadLine();
            }

            Console.WriteLine($"Subsentence «{subsentence}» most often repeats in the sentence «{storeDict.OrderByDescending(pair => pair.Value).FirstOrDefault().Key}»");
            Console.ReadLine();
        }

        public static int RepeatsCount(string sentence, string subsentence)
        {
            return new Regex(subsentence).Matches(sentence).Count;
        }
    }
}
