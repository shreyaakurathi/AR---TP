using System;

namespace substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string stg = "ABCD";
            int initiallength = 1;
            int firstindex = 0;
            int len = stg.Length;
            for (initiallength = 1; initiallength <= len; initiallength++)
            {
                for (firstindex = 0; firstindex <= len - initiallength; firstindex++)
                {
                    string sub = stg.Substring(firstindex, initiallength);
                    Console.WriteLine(sub);
                }
            }

        }
    }
}
