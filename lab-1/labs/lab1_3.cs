using System;

namespace lab1_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите х");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите у");
            y = Convert.ToDouble(Console.ReadLine());
            if ((y >= Math.Pow(x - 2, 2) - 3) && (x >= Math.Abs(y)) && (y >= 0))
            {
                Console.WriteLine("Поздравляю, Вы попали!");
            }
            else if ((y >= Math.Pow(x - 2, 2) - 3) && (x <= Math.Abs(y)) && (y <= 0))
            {
                Console.WriteLine("Поздравляю, Вы попали!");
            }
            else Console.WriteLine("Вы промазали!");
            Console.ReadKey();
        }
    }
}
