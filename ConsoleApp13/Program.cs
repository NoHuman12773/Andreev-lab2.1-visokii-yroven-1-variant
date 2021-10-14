using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите время:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите время:");
                double y = double.Parse(Console.ReadLine());
                if (((y < 1) && (x > -1) && (y > x + 1)) || 
                    ((y > -1) && (x > -1) && (y < -x - 1)) || 
                    ((y > -1) && (x < 1) && (y < x - 1)) || 
                    ((y < 1) && (x < 1) && (y > -x + 1))) 
                    Console.WriteLine("ПОПАЛ");

                else Console.WriteLine("НЕ ПОПАЛ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
