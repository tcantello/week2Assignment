using System;

namespace week2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 7;
            Console.WriteLine("This section was done by doing all math work inside Console.WriteLine(). Example: Console.WriteLine(-1 + 4 * myVar);");
            Console.WriteLine();
            Console.WriteLine(-1 + 4 * myVar);
            Console.WriteLine((35 + 5) % myVar);
            Console.WriteLine(14 + -4 * 6 / 12);
            Console.WriteLine(2 + 12 / 6 * 1 - myVar % 2);

            if (myVar * myVar < 10)
            {
                Console.WriteLine("myVar is less than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4");
            }
            Console.WriteLine();
            Console.WriteLine("This section was done by creating a new variable for each calculation. Then using the new variable in the Console.WriteLine. Example: int problem1 = -1 + 4 * myVar; then Console.WriteLine(problem1);");
            Console.WriteLine();
            int problem1 = -1 + 4 * myVar;
            int problem2 = (35 + 5) % myVar;
            int problem3 = 14 + -4 * 6 / 12;
            int problem4 = 2 + 12 / 6 * 1 - myVar % 2;
            int problem5 = myVar * myVar;

            Console.WriteLine(problem1);
            Console.WriteLine(problem2);
            Console.WriteLine(problem3);
            Console.WriteLine(problem4);

            if (problem5 < 10)
            {
                Console.WriteLine("myVar is less than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
