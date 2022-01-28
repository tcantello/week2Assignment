using System;

namespace week2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 7;
            Console.WriteLine(-1 + 4 * myVar);
            Console.WriteLine((35 + 5) % myVar);
            Console.WriteLine(14 + -4 * 6 / 12);
            Console.WriteLine(2 + 12 / 6 *1 - myVar % 2);

            if (myVar * myVar < 10)
            {
                Console.WriteLine("myVar is less than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4");
            }
        }
    }
}
