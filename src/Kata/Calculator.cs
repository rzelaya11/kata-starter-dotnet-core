using System;
using System.Linq;

public  class Calculator
{
    public int Sum(string data)
    {
        if (data == "")
            return 0;

        var input = data;
        var delimiters = new[] {",", "\n"};
        if (data.StartsWith("//"))
        {
            var tok = data.Split('\n');
            input = tok[1];
            delimiters = new[] {tok[0].Replace("//", "")};
        }

        var numbers = input.Split( delimiters, StringSplitOptions.None).Select(int.Parse).Where(x=> x<1001);
        var negatives = numbers.Where(x => x < 0);
        if (negatives.Any())
        {
            throw new Exception($"negatives not allowed: {string.Join(", ",negatives)}");
        }
        return numbers.Sum();
    }
}