using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxScore = 100;
            int score = 50;
            float percent = (float)score / MaxScore;
            Console.WriteLine();
            Console.WriteLine("Percentage is:" + percent);
        }
    }
}
