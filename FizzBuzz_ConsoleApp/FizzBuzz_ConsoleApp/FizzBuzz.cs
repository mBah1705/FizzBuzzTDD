using System;

namespace FizzBuzz_ConsoleApp
{
    public class FizzBuzz
    {
        private int min = 1;
        private int max = 100;

        public bool IsInRange(int i) => min <= i && i <= max;

        public string IsFizz(int i)
        {
            if (IsInRange(i))
            {
                return i % 3 == 0 ? "Fizz" : i.ToString();
            }
            return $"{i} is out of range!";
        }

        public string IsBuzz(int i)
        {
            if (IsInRange(i))
            {
                return i % 5 == 0 ? "Buzz" : i.ToString();
            }
            return $"{i} is out of range!";
        }

        public string IsFizzBuzz(int i)
        {
            if (IsInRange(i))
            {
                return (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : i.ToString();
            }
            return $"{i} is out of range!";
        }
    }
}
