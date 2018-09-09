using System;

namespace FizzBuzz_ConsoleApp
{
    public class FizzBuzz
    {
        private int min = 1;
        private int max = 100;

        private string value = string.Empty;

        public bool IsInRange(int i) => min <= i && i <= max;

        public void IsFizz(int i)
        {
            value += i % 3 == 0 ? "Fizz" : string.Empty;
        }

        public void IsBuzz(int i)
        {
            value += i % 5 == 0 ? "Buzz" : string.Empty;
        }

        public string ReturnValue(int v)
        {
            value = string.Empty;

            if (IsInRange(v))
            {

                IsFizz(v);
                IsBuzz(v);
                if (value == string.Empty)
                {
                    value = v.ToString();
                }
                return value;
            }
            return $"{v} is out of range!";
        }
    }
}
