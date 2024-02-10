using System;

namespace lab2_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x, y;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Программа определяет попадания в мишень");
                Console.WriteLine("Введите х");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите у");
                y = Convert.ToDouble(Console.ReadLine());
                if ((y >= Math.Pow(x - 2, 2) - 3) && (x >= Math.Abs(y)) && (y >= 0))
                {
                    Console.WriteLine("Поздравляю, Вы попали!\n");
                }
                else if ((y >= Math.Pow(x - 2, 2) - 3) && (x <= Math.Abs(y)) && (y <= 0))
                {
                    Console.WriteLine("Поздравляю, Вы попали!\n");
                }
                else Console.WriteLine("Вы промазали!\n");
            }
            Console.WriteLine("Выстрелы закончились");
            Console.ReadKey();
        }
    }
}
