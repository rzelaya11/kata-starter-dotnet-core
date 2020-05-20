using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

public partial class Calculator
{
    public int Sum(string data)
    {
        if(data =="" )return 0;

        var numbers = data.Split(',').Select(Int32.Parse).ToArray();
        
        return numbers[0] + (numbers.Length>1 ? numbers[1] : 0);
    }
}