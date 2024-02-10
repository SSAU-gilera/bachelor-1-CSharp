using System;

namespace lab2_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите а");
            double a = Convert.ToDouble(Console.ReadLine());
            if ((a != 2) && (a != -2) && (a != 0))
            {
                double z1 = Math.Pow(((1 + a + a * a) / (2 * a + a * a)) + 2 - ((1 - a + a * a) / (2 * a - a * a)), -1) * (5 - 2 * a * a);
                double z2 = (4 - a * a) / 2;
                Console.WriteLine("z1 = " + z1);
                Console.WriteLine("z2 = " + z2);
            }
            else Console.WriteLine("Недопустимое значение а");
        }
    }
}
