﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        private int min = 1;
        private int max = 100;

        public bool IsInRange(int i) => min <= i && i <= max;

        public bool IsFizz(int i)
        {
            if (IsInRange(i))
            {
                return i % 3 == 0;
            }

            Console.WriteLine($"{i} is out of range!");
            return false;
            
        }
    }


}