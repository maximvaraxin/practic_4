/*
 * Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 * 452 -> 11
 * 82 -> 10
 * 9012 -> 12 
 */

namespace App_6
{
    class Program
    {
        static void Main(string[] args)
        {   
           Console.Write($" Введите число: ");
           int num = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($" Сумма цифр числа { num } = { GetSum( num ) }");
           Console.WriteLine($" Сумма цифр числа(решение рекурсией) { num } = { GetSumRecursion( num ) }");
        }

        // возвращает сумму цифр в числе(рекурсия)
        static int GetSumRecursion( int number )
        {   

            if ( number < 10 )
			{
                return number;
			}

            return number % 10 + GetSumRecursion( number / 10 );
        }

        // возвращает сумму цифр в числе
        static int GetSum( int number)
        {
            int result = 0;

            while( number > 0 )
            {
                result = result + number % 10;
                number = number / 10;
            }

            return result;
        }
    }
}
