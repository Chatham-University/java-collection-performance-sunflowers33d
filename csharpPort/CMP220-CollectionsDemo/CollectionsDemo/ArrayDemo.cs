using System;
public class ArrayDemo
    {
        private int[] nums;

        public ArrayDemo(int howManyNums, Random rand)
        {
            nums = new int[howManyNums];
            for (int i = 0; i < howManyNums; i++)
            {
                nums[i] = rand.Next(howManyNums);
            }
            
            Console.WriteLine("The first few numbers are: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }