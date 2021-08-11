using System;

namespace dies
{
    public class die
    {
        int noofsides = 6;
    }
    public class randomnumber
    {
        int random;
        public int Roll()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            return number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int d1, d2;
            randomnumber random = new randomnumber();
            d1 = random.Roll();
            d2 = random.Roll();
            Console.WriteLine(d1 +" "+d2);
            int sum = d1 + d2;
            Console.WriteLine("sum=" + sum);
        }
    }
}
