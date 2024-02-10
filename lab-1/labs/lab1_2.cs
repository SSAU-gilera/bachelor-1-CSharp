using System;

namespace lab1_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            if ((x < 7) && (x > 3))
            {
                Console.WriteLine("Функция не определена");
            }
            else
            {
                if ((x <= -6) && (x >= -7))
                {
                    y = 2;
                }
                else
                if (x <= -2)
                {
                    y = 0.25 * x + 0.5;
                }
                else
                if (x <= 0)
                {
                    y = 2 - Math.Sqrt(-(x * x) - 4 * x);
                }
                else
                if (x <= 2)
                {
                    y = Math.Sqrt(4 - x * x);
                }
                else
                {
                    y = 2 - x;
                }
                Console.WriteLine("y = " + y);
            }
            Console.ReadKey();
        }
    }
}
