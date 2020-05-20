using System;
using System.Numerics;

public partial class Calculator
{
    public int Sum(string data)
    {
        if(data =="" )return 0;
        
        return Int32.Parse(data);
    }
}