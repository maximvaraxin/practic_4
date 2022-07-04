namespace App_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Quantity(12));
        }

        static int Quantity(int number)
        {   
            int res = 0;
            int count = 0;

            while (number != 0)
            {   
                res =number / 10;
                count++;
            }

            return count;
        }

    }
}
