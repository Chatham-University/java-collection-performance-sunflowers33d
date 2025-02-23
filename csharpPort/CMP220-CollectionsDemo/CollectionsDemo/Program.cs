using System;

public class Program
{
    public static int HOW_MANY_NUMS = (int)Math.Pow(10,8);
    // the seed should be changed to int64 5564011392837540628 eventually. this is just for testing
    public static int Seed = 556401139;
    public static void Main(string[] args)
    {
        Random rand = new Random(Seed);

        // oh this is SO cursed.
        // this is my way of doing java's System.currentTimeMillis() which starts at UNIX epoch time
        long start = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        new ArrayDemo(HOW_MANY_NUMS, rand);
        long end = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        Console.WriteLine(String.Format("Array Time: " + ((end - start) / 1000.0)) + " seconds");
        
        start = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        new VectorDemo(HOW_MANY_NUMS, rand);
        end = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        Console.WriteLine(String.Format("Vector (actually List) Time: " + ((end - start) / 1000.0)) + " seconds");
    }
}