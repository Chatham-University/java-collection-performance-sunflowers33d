using System;

public class Program
{
    public static int HowManyNums = (int)Math.Pow(10,8);
    // the seed should be changed to int64 5564011392837540628 eventually. this is just for testing
    public static int Seed = 556401139;

    private static int _howManyTests = 3;
    private static double[] _arrayTests;
    private static double[] _vectorTests;
    private static double[] _linkedListTests;
    private static double[] _arrayListTests;
    private static double _arrayTime;
    private static double _vectorTime;
    private static double _linkedListTime;
    private static double _arrayListTime;
    public static void Main(string[] args)
    {
        Random rand = new Random(Seed);
        
        _arrayTests = new double[_howManyTests];
        _vectorTests = new double[_howManyTests];
        _linkedListTests = new double[_howManyTests];
        _arrayListTests = new double[_howManyTests];
        for (int i = 0; i < _howManyTests; i++)
        {
            // oh this is SO cursed.
            // this is my way of doing java's System.currentTimeMillis() which starts at UNIX epoch time
            long start = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            new ArrayDemo(HowManyNums, rand);
            long end = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            _arrayTime = (end - start) / 1000.0;
            Console.WriteLine(String.Format("Array Time: " + _arrayTime + " seconds"));
            _arrayTests[i] = _arrayTime;
            
            // vector test, same cursed UNIX epoch time solution
            start = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            new VectorDemo(HowManyNums, rand);
            end = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;  
            _vectorTime = (end - start) / 1000.0;
            Console.WriteLine(String.Format("Vector (actually List) Time: " + _vectorTime + " seconds"));
            _vectorTests[i] = _vectorTime;
            
            start = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            new LinkedListDemo(HowManyNums, rand);
            end = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;  
            _linkedListTime = (end - start) / 1000.0;
            Console.WriteLine(String.Format("LinkedList Time: " + _linkedListTime + " seconds"));
            _linkedListTests[i] = _linkedListTime;
            
            start = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            new LinkedListDemo(HowManyNums, rand);
            end = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;  
            _arrayListTime = (end - start) / 1000.0;
            Console.WriteLine(String.Format("ArrayList Time: " + _linkedListTime + " seconds"));
            _arrayListTests[i] = _arrayListTime;
        }
        
        Array.ForEach(_arrayTests, Console.WriteLine);
    }
}