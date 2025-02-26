using System;
public class ArrayDemo
    {
        private int[] _nums;

        public ArrayDemo(int howManyNums, Random rand)
        {
            _nums = new int[howManyNums];
            for (int i = 0; i < howManyNums; i++)
            {
                _nums[i] = rand.Next(howManyNums);
            }
            
            Console.WriteLine("The first few numbers are: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(_nums[i]);
            }
        }
    }