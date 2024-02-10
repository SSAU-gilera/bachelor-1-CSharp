using System;

namespace lab2___3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисляет сумму ряда и количество членов");
            double e, x, curr = 1, arctg = Math.PI / 2;
            int n = 0;
            Console.WriteLine("Введите погрешность:");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х:");
            x = Convert.ToDouble(Console.ReadLine());
            if (x > 1)
            {
                do
                {
                    curr = Math.Pow(-1, n + 1) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                    n++;
                    arctg += curr;
                } while (Math.Abs(curr) > Math.Abs(e));
                Console.WriteLine("Сумма ряда равна: " + arctg);
                Console.WriteLine("Количество членов: " + n);
            }
            else
            {
                Console.WriteLine("Нельзя посчитать");
            }

            
        }
    }
}
