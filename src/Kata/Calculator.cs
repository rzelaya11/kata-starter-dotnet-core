using System;
using System.Linq;

public  class Calculator
{
    public int Sum(string data)
    {
        if (data == "")
            return 0;

        var numbers = data.Split( new [] {",","\n"}, StringSplitOptions.None).Select(int.Parse);
        return numbers.Sum();
    }
}