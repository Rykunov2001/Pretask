using System;
using System.Diagnostics;

namespace PreTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(Euclidean.FindGCD( -23 , 23,ref stopwatch));
            Console.WriteLine( stopwatch.Elapsed);
            stopwatch.Restart();
            Console.WriteLine(Euclidean.FindBinaryGDC(1568, 4, ref stopwatch));
            Console.WriteLine(stopwatch.Elapsed);

        }
    }
}
