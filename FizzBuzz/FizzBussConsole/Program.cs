using System;

namespace FizzBussConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz.GetStringFor(i));
            }
            Console.ReadKey();
        }
    }
}
