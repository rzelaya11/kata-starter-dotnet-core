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
            var token = text.Split(',');

            if (token.Length > 1)
                return int.Parse(token[1]) + int.Parse(token[0]);
            return int.Parse(token[0]);
        }
    }
}