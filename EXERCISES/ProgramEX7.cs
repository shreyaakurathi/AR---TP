using System;

namespace EX7
{
    class Program
    {
        static void Main(string[] args)
        {
            ///use int to declare variables
            int originalfarenheit = 212;
            /// convert to celcius
            int celcius = (int)((originalfarenheit - 32) / 9) * 5;
            Console.WriteLine();
            Console.WriteLine("Temp in Celcius:" + celcius);
            Console.WriteLine();
            ///convert to farenheit
            int faren = (int)((celcius * 9) / 5) + 32;
            Console.WriteLine("Temp in Faren:"+faren);

            /// use float

            float ogf = 0;
            float c = (float)((ogf - 32) / 9) * 5;
            Console.WriteLine();
            Console.WriteLine("CELCIUS(FLOAT):" + c);
            Console.WriteLine();
            float f = (float)((c * 9) / 5) + 32;
            Console.WriteLine("Faren:" + f);

            /// use double
            double original = 0;
            double cel = (double)((original - 32) / 9)*5;
            Console.WriteLine();
            Console.WriteLine("Temp celcuis(doble):" + cel);
            Console.WriteLine();
            double fr = (double)((cel * 9) / 5) + 32;
            Console.WriteLine("Farem Double:" + fr);

        }
    }
}
