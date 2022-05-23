# Plus-Minus-HackerRank
Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.



<img width="1007" alt="Ekran Resmi 2022-05-23 12 55 52" src="https://user-images.githubusercontent.com/105243448/169794476-39d3faad-a9f5-40f6-82f7-eedb08ae4c0e.png">







```

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
        
      foreach(var a in arr){
          
          if(a >0){
              positiveCount++;
              
          }
          if( a == 0){
              zeroCount++;
          }
          if(a < 0){
              negativeCount++;
          }
      }
      
      float first       =    (float)positiveCount / (float)len;
      float second      =    (float)negativeCount / (float)len;
      float third       =    (float)zeroCount / (float)len;
      
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



