using System;
using System.Collections.Generic;

public class ArrayListDemo {
    private ArrayList<int> nums;

    public ArrayListDemo(int howManyNums, Random rand) {
        nums = new ArrayList<Integer>();
        for(int i = 0; i < howManyNums; i++) {
            nums.add(rand.nextInt(howManyNums));
        }

        System.out.println("The first few numbers are: ");
        for(int i = 0; i < 6; i++){
            Console.WriteLine(nums.get(i));
        }
    }
}