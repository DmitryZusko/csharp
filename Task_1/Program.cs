/* За заданим восьмизначним натуральним числом знаходить середнє арифметичне цифр цього числа та кількість ненульових цифр. */

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter eight-digit natural number: ");
            var userNum = Console.ReadLine();
            var counter = 0;
            double sum = 0;

            foreach (char ch in userNum)
            {
                var number = char.GetNumericValue(ch);
                //для char TryParse не працює, воно вимагає ReadOnlySpan<char>. А вот GetNumericValue хорошо, но вертає double, того sum я зразу і оголосив як double
                sum += number;
                counter += Convert.ToInt32(!number.Equals(0));
            }

            sum /= userNum.Length;
            Console.WriteLine($"Number is {userNum}. \n Avarage is {sum}. \n Non-zero numbers: {counter}.");

            Console.ReadLine();
        }
    }
}
