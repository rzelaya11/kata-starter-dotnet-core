using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string userInput = "")
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }
            
            var separators = new []{",","\n"};

            var input = userInput;
            if (input.StartsWith("//"))
            {
                var parts = userInput.Split("\n");
                separators = new[] {parts.First().Replace("//", "")};
                input = parts.Last();
            }

            var tok = input.Split(separators, StringSplitOptions.None).Select(int.Parse).ToArray();
            return tok.Sum();
        }
    }
}