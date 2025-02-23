// https://stackoverflow.com/questions/64200744/c-sharp-equivalent-of-c-vector-vectorstring-megavec
// "The C# equivalent to a C++ Vector is List."
using System;
using System.Collections.Generic;
using System.Linq;

public class VectorDemo {
    private List<int> nums;
    public VectorDemo(int howManyNums, Random rand) {
        nums = new List<int>();
        for(int i = 0; i < howManyNums; i++) {
            nums.Add(rand.Next(howManyNums));
        }

        Console.WriteLine("The first few numbers are: ");
        for(int i = 0; i < 6; i++)
        {
            Console.WriteLine(nums.ElementAt(i));
        }
    }
}