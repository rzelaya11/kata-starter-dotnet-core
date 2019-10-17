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

            var separators = new char[] {',', '\n'};
            var numbers = text.Split(separators)
                .Select(int.Parse)
                .ToArray();

            return numbers.Sum();
        }
    }
}