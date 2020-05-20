using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

public partial class Calculator
{
    public int Sum(string data)
    {
        if(data =="" )return 0;

        var delimiters = new[] {',', '\n'};
        var input = data;

        if (data.StartsWith("//"))
        {
            var tokens = data.Split('\n');
            delimiters = new[] {tokens[0].Replace("//","")[0]};
            input = tokens[1];
        }

        var numbers = input.Split(delimiters).Select(Int32.Parse).ToArray();

        var sum = 0;

        foreach (var n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}