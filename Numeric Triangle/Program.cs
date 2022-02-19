using System;

namespace Numeric_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
         for(int i=1; i<=6; i++)
            {
                Console.Write(" ");
                for(int j=1; j<=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
