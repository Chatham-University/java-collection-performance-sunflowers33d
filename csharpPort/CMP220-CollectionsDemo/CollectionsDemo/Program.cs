using System;

public class Program
{
    public static int HOW_MANY_NUMS = (int)Math.Pow(10,8);
    // the seed should be changed to int64 5564011392837540628 eventually. this is just for testing
    public static int Seed = 556401139;

    private static int HowManyTests = 3;
    private static double[] arrayTests;
    private static double[] vectorTests;
    private static double ArrayTime;
    private static double VectorTime;
    public static void Main(string[] args)
    {
        Random rand = new Random(Seed);

        
        
        
        arrayTests = new double[HowManyTests];
        vectorTests = new double[HowManyTests];
        for (int i = 0; i < HowManyTests; i++)
        {
            // oh this is SO cursed.
            // this is my way of doing java's System.currentTimeMillis() which starts at UNIX epoch time
            long start = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            new ArrayDemo(HOW_MANY_NUMS, rand);
            long end = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            ArrayTime = (end - start) / 1000.0;
            Console.WriteLine(String.Format("Array Time: " + ArrayTime + " seconds"));
            arrayTests[i] = ArrayTime;
            
            // vector test, same cursed UNIX epoch time solution
            start = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            new VectorDemo(HOW_MANY_NUMS, rand);
            end = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;  
            VectorTime = (end - start) / 1000.0;
            Console.WriteLine(String.Format("Vector (actually List) Time: " + VectorTime + " seconds"));
            vectorTests[i] = VectorTime;
        }
    }
}