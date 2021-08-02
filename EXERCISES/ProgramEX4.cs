using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude:");
            int firstalt = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter second altitude:");
            int secondalt = int.Parse(Console.ReadLine());
            ///performing change
            int change = firstalt - secondalt;
            Console.WriteLine();
            Console.WriteLine("Change is:" + change);
        }
    }
}
