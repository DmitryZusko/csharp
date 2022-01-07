/* Використовуючи рекурсію, знайти всі парні числа з заданого набору цілих чисел. Масив не оголошувати. */

using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start our game: you enter an integer number, I check is it even. If you want to stop playing just print «I am ball one».");
            var result = EvenChecker();
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static string EvenChecker()
        {
            Console.WriteLine("Your turn: ");
            var userInput = Console.ReadLine();

            if (userInput == "I am ball one")
            {
                return "Oh, you are finally done, jerky asshole! Go fuck yourself!";
            }

            var userNum = 0;
            if (!int.TryParse(userInput, out userNum))
            {
                Console.WriteLine("Are you fucking blind?! Then I'll say you one more goddamn time: enter THE FUCKING INTEGER NUMBER, goatfucker.");
                return EvenChecker();
            }
            Console.WriteLine($"Is your number even? {(userNum % 2 == 0 ? true : false)}");

            return EvenChecker();
        }
    }
}
