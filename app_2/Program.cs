namespace App_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Количество цифр в числе: ");
            Console.WriteLine(Quantity( number ));

        }

        // возвращает количество чисел
        static int Quantity(int number)
        {   
            int count = 0;

            while (number > 0)
            {   
                number = number / 10;
                count++;
            }

            return count;
        }

    }
}
