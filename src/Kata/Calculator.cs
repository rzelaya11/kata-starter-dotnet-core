using System;
using System.Linq;

public class Calculator
{
    public int Sum(string s = "")
    {
        if(s == "" )
            return 0;
        var numbers = s.Split(",").Select(int.Parse).ToArray();
       
        return numbers.Sum();
    }
}