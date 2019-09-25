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

            var tok = userInput.Split(",").Select(int.Parse).ToArray();
            return tok[0] + (tok.Count()>1 ? tok[1] :0);
        }
    }
}