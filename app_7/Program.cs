/*
 *  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 *  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
 *  6, 1, 33 -> [6, 1, 33]
 */

namespace App_
{
    class Programm
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] mass = GetRandomMass( len );

            Console.Write($"Массив: ");
            PrintMass(mass);
        }
        
        // заполняет массив данными с клавиатуры
        static int[] GetRandomMass( int len )
        {   
            int[] mass = new int[ len ];

            for (int i = 0; i < mass.Length; i++)
			{
                mass[i] = Convert.ToInt32(Console.ReadLine());
			}

            return mass;

        }

        // возвращает массив в консоль
        static void PrintMass( int[] mass, int i = 0 )
        {
            if( i < mass.Length)
            {
                Console.Write( $"{ mass[i] } " );
                PrintMass( mass, i + 1 );  
            }
        }
    }
}