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
                delimiters = tokens[0].Replace("//", "")
                    .Replace("[", "")
                    .Split("]");
                input = tokens.Last();
            }

            var numbers = input
                .Split(delimiters, StringSplitOptions.None)
                .Select(int.Parse)
                .Where(n => n <= 1000)
                .ToArray();

            var negatives = numbers.Where(n => n < 0).ToArray();

            if (negatives.Any())
            {
                throw new Exception($"negatives not allowed: {string.Join(", ", negatives)}");
            }

            if (numbers.Length == 1)
                return numbers.First();

            return numbers.Sum();
        }
    }
}