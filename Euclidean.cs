using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace PreTask
{
    class Euclidean
    {
        //private Stopwatch stopwatch = new Stopwatch();

        public int FindGDC(int a, int b, ref Stopwatch stopwatch)
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
        public int FindGDC(int a,int b,int c, ref Stopwatch stopwatch)
        {
            int result = FindGDC(a, b, stopwatch);
            result = FindGDC(result, c);
            return result;
        }
        public int FindGDC(int a,int b,int c,int d)
        {
            int result = FindGDC(a, b, c);
            result = FindGDC(result, d);
            
            return result;
        }
        public int FIndGDC(int a, int b, int c, int d,int e)
        {
            int result = FindGDC(a, b, c,d);
            result = FindGDC(result, e);
            return result;
        }
        public int FindBinaryGDC(int a,int b,ref stopwa)
        {
            stopwatch.Start();
            if (a == b)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a % 2 == 0)
            {
                if (b % 2 == 1)
                    return FindBinaryGDC(a / 2, b);
                else
                    return 2 * FindBinaryGDC(a / 2, b / 2);
            }
            else
            {
                if (b % 2 == 0)
                    return FindBinaryGDC(a, b / 2);
                if (a > b)
                    return FindBinaryGDC((a - b) / 2, b);
                else
                    return FindBinaryGDC((b - a) / 2, a);
            }
            
        }

    }
}
