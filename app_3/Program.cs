/*
 * Решение в группах задач:
 * Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
 * 4 -> 24 
 * 5 -> 120
 */

namespace App_3
{
    class Program
    {
        static void Main(string[] args)
        {   
           Console.Write($" Введите число: ");
           double number = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($" Факториал числа { number } = { GetFactorial( number ) }");
           
           Console.WriteLine($" Факториал числа (рекурсией) { number } = { GetFactorialRecursion( number ) }");
        }

        // возвращает факториал циклом
        static double GetFactorial( double num )
        {   
            double result = 1;

            for (int i = 1; i <= num; i++)
			{
                result = i * result;
			}

            return result;
        }

        // возвращает факториал рекурсией
        static double GetFactorialRecursion( double num )
        {         
            return num = (num == 0 || num == 1) ? 1 : num * GetFactorialRecursion( num - 1 );
        }
    }
}
