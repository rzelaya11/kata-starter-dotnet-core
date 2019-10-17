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
            var numbers = text.Split(',')
                .Select(int.Parse)
                .ToArray();

            return numbers.Sum();
        }
    }
}