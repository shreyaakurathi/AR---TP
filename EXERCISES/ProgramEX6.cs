using System;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter angle in degrees:");
            float angle = float.Parse(Console.ReadLine());
            Console.WriteLine();
            /// calculate cosine
            float cosine = (float)Math.Cos(angle * Math.PI / 180);
            float sin = (float)Math.Sin(angle * Math.PI / 180);
            /// print
            Console.WriteLine("Cosine is:" + cosine);
            Console.WriteLine();
            Console.WriteLine("sine is :" + sin);
        }
    }
}
