using System;

public class Calculator
{
    public int Sum(string s = "")
    {
        if(s == "" )
            return 0;
        return Int32.Parse(s);   
    }
}