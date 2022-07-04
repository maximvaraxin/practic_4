﻿/*
 * Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 * 452 -> 11
 * 82 -> 10
 * 9012 -> 12 
 */

namespace App_3
{
    class Program
    {
        static void Main(string[] args)
        {   
           Console.Write($" Введите основание: ");
           double num_1 = Convert.ToInt32(Console.ReadLine());

           Console.Write($" Введите показатель степени: ");
           double num_2 = Convert.ToInt32(Console.ReadLine());
           
           
           Console.WriteLine($" { num_1 } в степени { num_2 } = { Pow( num_1, num_2 ) }");
        }

        // возвращает возведение в степень
        static double Pow( double num_1, double num_2 )
        {   
            double result = 1;

            for (int i = 0; i < num_2; i++)
			{
                result = result * num_1;
			}
            
            return result;
        }
    }
}
