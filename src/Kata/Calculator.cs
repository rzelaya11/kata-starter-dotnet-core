using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string text = "")
        {

            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            var separators = new [] {",", "\n"};
            var input = text;
            
            if (input.StartsWith("//"))
            {
                var parts = input.Split("\n");

                separators = new[]
                {
                    parts
                        .First()
                        .Replace("//", "")
                        .Replace("[", "")
                        .Replace("]", "")
                };

                input = parts.Last();
            }
            
            var numbers = input.Split(separators, StringSplitOptions.None)
                .Select(int.Parse)
                .Where((x) => x <= 1000)
                .ToArray();

            var negatives = numbers.Where((x) => x < 0).ToArray();
            if(negatives.Any())
                throw new Exception($"negatives not allowed: {string.Join(", ", negatives)}");
            return numbers.Sum();
        }
    }
}