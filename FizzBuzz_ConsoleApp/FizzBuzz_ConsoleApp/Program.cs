using System;

namespace FizzBuzz_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            FizzBuzz buzzer = new FizzBuzz();
            //Should print 120 is out of range;
            buzzer.IsFizz(120);
            Console.ReadLine();
        }
    }
}
