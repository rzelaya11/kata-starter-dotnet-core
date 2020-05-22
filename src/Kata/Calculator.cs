using System;
using System.Linq;

public class Calculator
{
    public int Sum(string s = "")
    {
        if(s == "" )
            return 0;
        var numbers = s.Split(",").Select(int.Parse).ToArray();
        if (numbers.Length == 1) return numbers[0];
        return numbers[0] + numbers[1];
    }
}