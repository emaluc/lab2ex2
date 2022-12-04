using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va afisa factorialul unui numar n, n fiind citit
de la tastatura.*/
             
            Console.WriteLine("Scrieti un numar:");

            ulong x = ulong.Parse(Console.ReadLine());
            ulong fact = 1;

            while (x > 0)
            {
                fact = fact * x;
                x = x - 1;
            }
            Console.WriteLine("Factorialul numarului introdus este: " + fact);
        }
    }
}
