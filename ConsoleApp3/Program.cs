using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* for (int m = 1; m < 5; m++)
              {
                 for (int i = 0; i < 5; i++)
                 {
                     for (int j = 1; j < 5; i++)
                     {
                         Console.WriteLine("Hello World!");
                     }
                 }

             }*/
            LinearSearch();

        }

        static void Linear()
        {

        }
        static void Quadratic()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 5; i++)
                {
                    Console.WriteLine("Hello World!");
                }
            }

        }
        static void LinearSearch()
        {
            int key = 7;
            int[] A = { 8, 6, 9, 7, 2, 78, 10 };
            bool found = false;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == key)
                {
                    found = true;
                    continue;
                }
            }
            if (found)
            {
                Console.WriteLine("The element was found.");
            }
            else
            {
                Console.WriteLine("The element was NOT found.");
            }
        }

    }
}