using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //double O, O2, S;
            //double x = 0;
            ////Console.WriteLine("Введите x");
            ////double x = double.Parse(Console.ReadLine());
            //O = Math.Sqrt(Math.Pow(x, 3/5));
            //for (int k=1; k<=3;k++)
            //{
            //  double S1 = Math.Pow(x, k) / k;
            //    S = Math.Pow(x, 2) + S1;
            //}
            //Console.WriteLine("Ответ: " + S);

            for (double x = -5; x <= 10; x += 0.2)
            {
                double y=0;
                if (x < 12.5) y = Math.Pow(x, 2);
                else if (x > 12.5) y = Math.Pow(x, 2) - 3 * x + 2.5 * Math.Pow(x, 2);
                else y = Math.Exp(x) + 5 + Math.Cos(0.001 * x);
                Console.WriteLine("|{0,13:F1}|{1,14:F2}|",x,y);
            }
        }
    }
}
