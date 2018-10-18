using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static long SumOfAllDigits(long input)
    {
        var digits = input.ToString().ToCharArray();
        var sum = 0L;
        foreach (var c in digits)
        {
            sum += c-48;
        }
        Console.Error.WriteLine("[INFO] Sum is {0} for input {1}", sum, input.ToString());
        return sum;
    }

    static long NextGen(long input)
    {
        var nextGen = input+SumOfAllDigits(input);
        Console.Error.WriteLine("[INFO] Next gen of {0} is {1}", input, nextGen);
        return nextGen;
    }    
    
    static void Main(string[] args)
    {
        long r1 = long.Parse(Console.ReadLine());
        long r2 = long.Parse(Console.ReadLine());

        while (r1 != r2)
        {
            if (r1 > r2)
                r2 = NextGen(r2);
            else
                r1 = NextGen(r1);
        }
        Console.WriteLine(r1);
    }
}
