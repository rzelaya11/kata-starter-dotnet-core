using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string userInput = "")
        {
            if (userInput.Length == 0) return 0;

            var numbers = userInput
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 1)
                return numbers.First();

            return numbers.First() + numbers.Last();
        }
    }
}