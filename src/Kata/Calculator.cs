using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string userInput = "")
        {
            if (userInput.Length == 0) return 0;
            var delimiters = new []{",", "\n"};
            var input = userInput;
            if (userInput.StartsWith("//"))
            {
                var tokens = userInput.Split('\n');
                delimiters = new[] {tokens[0].Replace("//", "")};
                input = tokens.Last();
            }

            var numbers = input
                .Split(delimiters, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 1)
                return numbers.First();

            return numbers.Sum();
        }
    }
}