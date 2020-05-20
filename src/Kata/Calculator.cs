using System;
using System.Linq;

public  class Calculator
{
    public int Sum(string data)
    {
        if (data == "")
            return 0;

        var numbers = data.Split(",").Select(int.Parse);
        if (numbers.Count() == 1)
        {
            return numbers.First();
        }
        return numbers.First() + numbers.Last();
    }
}