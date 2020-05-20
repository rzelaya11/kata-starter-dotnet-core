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
        
        var numbers = data.Split(delimiters).Select(Int32.Parse).ToArray();

        var sum = 0;

        foreach (var n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}