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

            var tok = userInput.Split(new []{",","\n"}, StringSplitOptions.None).Select(int.Parse).ToArray();
            return tok.Sum();
        }
    }
}