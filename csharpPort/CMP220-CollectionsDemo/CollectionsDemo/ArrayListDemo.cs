using System;
using System.Collections;
using System.Collections.Generic;

public class ArrayListDemo {
    private ArrayList _nums;

    public ArrayListDemo(int howManyNums, Random rand) {
        _nums = new ArrayList();
        for(int i = 0; i < howManyNums; i++) {
            _nums.Add(rand.Next(howManyNums));
        }

        // i don't think this is right
        Console.WriteLine("The first few numbers are: ");
        for(int i = 0; i < 6; i++){
            Console.WriteLine(_nums[i]);
        }
    }
}