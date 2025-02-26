﻿using System;
using System.Collections.Generic;
using System.Linq;

// it didn't let me use sealed/override here, hopefully not a problem..?
public class LinkedListDemo {
    private LinkedList<int> _nums;
    public LinkedListDemo(int howManyNums, Random rand) {
        _nums = new LinkedList<int>();
        for(int i = 0; i < howManyNums; i++) {
            // is this really an equivalent to nextInt?
            _nums.AddLast(rand.Next(howManyNums));
        }
        
        Console.WriteLine("The first few numbers are: ");
        for(int i = 0; i < 6; i++)
        {
            Console.WriteLine(_nums.ElementAt(i));
        }
    }
}