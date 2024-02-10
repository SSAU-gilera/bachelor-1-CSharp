using System;

namespace lab2_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Программа выводит таблицу значений функции");
            Console.WriteLine("Введите xmin:");
            double xmin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите xmax:");
            double xmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг:");
            double dx = Convert.ToDouble(Console.ReadLine());
            double y;
            Console.WriteLine("Значения функции на интервале oт {0} до {1} и с шагом {2} :", xmin, xmax, dx);
            Console.WriteLine("{0, 6}{1, 12}", "x", "y");
            for (double x = xmin; x <= xmax; x += dx)
            {
                if ((x < -7) || (x > 3))
                {
                    Console.WriteLine("{0, 8:0.00}         -", x);
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
                    {
                        y = x <= 2 ? Math.Sqrt(4 - x * x) : 2 - x;
                    }
                    Console.WriteLine("{0, 8:0.00}{1, 12:0.00}", x, y);
                }
            }
                Console.ReadLine();

            
        }
    }
}
