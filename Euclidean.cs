using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace PreTask
{
    public class Euclidean
    {
        //private Stopwatch stopwatch = new Stopwatch();

        public static int FindGDC(int a, int b, ref Stopwatch stopwatch)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;     
            }            
            return a;
        }
        public static int FindGDC(int a,int b,int c, ref Stopwatch stopwatch)
        {
            int result = FindGDC(a, b, ref stopwatch);
            result = FindGDC(result, c, ref stopwatch);
            return result;
        }
        public static int FindGDC(int a,int b,int c,int d, ref Stopwatch stopwatch)
        {
            int result = FindGDC(a, b, c, ref stopwatch);
            result = FindGDC(result, d, ref stopwatch);
            
            return result;
        }
        public static int FindGDC(int a, int b, int c, int d,int e, ref Stopwatch stopwatch)
        {
            int result = FindGDC(a, b, c, d, ref stopwatch);
            result = FindGDC(result, e, ref stopwatch);
            return result;
        }
        public static int FindBinaryGDC(int a,int b, ref Stopwatch stopwatch)
        {
            
            if (a == b)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a % 2 == 0)
            {
                if (b % 2 == 1)
                    return FindBinaryGDC(a / 2, b, ref stopwatch);
                else
                    return 2 * FindBinaryGDC(a / 2, b / 2, ref stopwatch);
            }
            else
            {
                if (b % 2 == 0)
                    return FindBinaryGDC(a, b / 2, ref stopwatch);
                if (a > b)
                    return FindBinaryGDC((a - b) / 2, b, ref stopwatch);
                else
                    return FindBinaryGDC((b - a) / 2, a, ref stopwatch);
            }
            
        }

    }
}
