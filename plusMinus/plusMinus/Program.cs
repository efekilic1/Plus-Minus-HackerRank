using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;
        int len = arr.Count;

        foreach (var a in arr)
        {

            if (a > 0)
            {
                positiveCount++;

            }
            if (a == 0)
            {
                zeroCount++;
            }
            if (a < 0)
            {
                negativeCount++;
            }
        }

        float first = (float)positiveCount / (float)len;
        float second = (float)negativeCount / (float)len;
        float third = (float)zeroCount / (float)len;

        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
