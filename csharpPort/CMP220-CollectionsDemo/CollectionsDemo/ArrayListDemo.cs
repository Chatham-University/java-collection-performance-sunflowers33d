using System;
using System.Collections;
using System.Collections.Generic;

public class ArrayListDemo {
    private ArrayList nums;

    public ArrayListDemo(int howManyNums, Random rand) {
        nums = new ArrayList();
        for(int i = 0; i < howManyNums; i++) {
            nums.Add(rand.Next(howManyNums));
        }

        // i don't think this is right
        Console.WriteLine("The first few numbers are: ");
        for(int i = 0; i < 6; i++){
            Console.WriteLine(nums[i]);
        }
    }
}