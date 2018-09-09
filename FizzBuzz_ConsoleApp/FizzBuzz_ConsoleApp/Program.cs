using System;

namespace FizzBuzz_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz buzzer = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(buzzer.ReturnValue(i));
            }

            //Should print 120 is out of range;
            Console.WriteLine(buzzer.ReturnValue(120));
            Console.ReadLine();
        }
    }
}
