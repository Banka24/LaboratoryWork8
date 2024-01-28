using System;
using System.Runtime.ConstrainedExecution;

namespace LaboratoryWork8
{
    internal class Program
    {
        static float Power(int number, int level)
        {
            float p = 1;

            for (int i = 1; i <= level; i++)
            {
                p *= number;
            }

            return p;
        }
        static void Power(int number, int level, out float result)
        {
            result = 1;
            for (int i = 1; i <= level; i++)
            {
                result *= number;
            }
        }

        static float Factorial(int maxNumber)
        {
            float p = 1;

            for(int i = 1;i <= maxNumber; i++)
            {
                p *= i;
            }

            return p;
        }

        static void Factorial(int maxNumber, out float result)
        {
            result = 1;

            for (int i = 1; i <= maxNumber; i++)
            {
                result *= i;
            }
        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            float f = Power(x+y, n) + a * Factorial(c) / Power(c, m);

            //Power(x + y, n, out float p1);
            //Power(c, m, out float p2);
            //Factorial(y, out float p3);

            //float f = p1 + a * p3 / p2;

            Console.WriteLine($"{f:f1}");
        }
    }
}
