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

            return int.Parse(text);
        }
    }
}