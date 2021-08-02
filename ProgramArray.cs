using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] original = new int []{ 5, 10, 15 };
            int spaces = 1;
            
            Console.WriteLine("Original: ");
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write(original[i] + " ");
            }
          
            
            for (int i = 0; i < spaces; i++)
            {
                int end, a;
                //Stores the last element of array  
                end = original[original.Length - 1];

                for (a = original.Length - 1; a > 0; a--)
                {
                    original[a] = original[a - 1];
                } 
                original[0] = end;
            }

            Console.WriteLine();

            //Displays resulting array after rotation  
            Console.WriteLine("Rotated: ");
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write(original[i] + " ");
            }
        }
    }
}
  

