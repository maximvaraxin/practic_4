/*
 *    Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
 *    7 -> 28
 *    4 -> 10
 *    8 -> 36
 *    
 */

namespace App_1
{
    class Programm
    {
        static void Main(string[] args)
        {   
           Console.Write($" Введите число: ");
           int number = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($" Сумма чисел диапазона = { GetSum( number ) }");

           Console.WriteLine($" Сумма чисел диапазона ( решение рекурсией ) = { GetSumRecursion( number ) }");
        }

        // возвращает сумму чисел
        static int GetSum( int num )
        {   
            int result = 0;

            for (int i = 1; i <= num; i++)
			{
                result += i;
			}

            return result;
        }

        // возвращает сумму чисел(рекурсия)  
        static int GetSumRecursion( int number )
        {   
            int result = 0;

            return result = number <= 0 ? result : number + GetSumRecursion( number - 1 );            
        }
    }
}