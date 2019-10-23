using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string userInput = "")
        {
            if (userInput.Length == 0) return 0;
            return Int32.Parse(userInput);
        }
    }
}