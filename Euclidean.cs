using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace PreTask
{
    /// <summary>
    /// Class Euclidean calculates GCD
    /// </summary>
    public class Euclidean
    {
        /// <summary>
        /// Euclid's method for finding GCD.
        /// Takes 3 parameters, 2 numbers and a time counter,
        /// returns the greatest common divisor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="stopwatch"></param>
        /// <returns></returns>
        public static int FindGCD(int a, int b, ref Stopwatch stopwatch)
        {
            if (b < 0 || b < 0)
                throw new Exception("The number must not be negative");
            if (b == 0 && a == 0)
                throw new Exception("The number must not be zero");
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;     
            }            
            return a;
        }
        /// <summary>
        /// Euclid's method for finding GCD.
        /// Takes 4 parameters, 3 numbers and a time counter,
        /// returns the greatest common divisor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="stopwatch"></param>
        /// <returns></returns>
        public static int FindGCD(int a,int b,int c, ref Stopwatch stopwatch)
        {
            int result = FindGCD(a, b, ref stopwatch);
            result = FindGCD(result, c, ref stopwatch);
            return result;
        }
        /// <summary>
        /// Euclid's method for finding GCD.
        /// Takes 5 parameters, 4 numbers and a time counter,
        /// returns the greatest common divisor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="stopwatch"></param>
        /// <returns></returns>
        public static int FindGCD(int a,int b,int c,int d, ref Stopwatch stopwatch)
        {
            int result = FindGCD(a, b, c, ref stopwatch);
            result = FindGCD(result, d, ref stopwatch);
            
            return result;
        }
        /// <summary>
        /// Euclid's method for finding GCD.
        /// Takes 6 parameters, 5 numbers and a time counter,
        /// returns the greatest common divisor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="stopwatch"></param>
        /// <returns></returns>
        public static int FindGCD(int a, int b, int c, int d,int e, ref Stopwatch stopwatch)
        {
            int result = FindGCD(a, b, c, d, ref stopwatch);
            result = FindGCD(result, e, ref stopwatch);
            return result;
        }
        /// <summary>
        ///  Binary method for finding GCD.
        ///  Takes 3 parameters, 2 numbers and a time counter,
        ///  returns the greatest common divisor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="stopwatch"></param>
        /// <returns></returns>
        public static int FindBinaryGDC(int a,int b, ref Stopwatch stopwatch)
        {
            if (b < 0 || b < 0)
                throw new Exception("The number must not be negative");
            if (b == 0 && a == 0)
                throw new Exception("The number must not be zero");
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
        /// <summary>
        /// Prepares a tuple of data for plotting a histogram.
        /// Takes 2 parameters, 2 time collections,
        /// returns a tuple
        /// </summary>
        /// <param name="stopwatch1"></param>
        /// <param name="stopwatch2"></param>
        /// <returns></returns>
        public (Stopwatch[], Stopwatch[]) GetGistogramm(Stopwatch[] stopwatch1, Stopwatch[] stopwatch2)
        {
            (Stopwatch[], Stopwatch[]) TimeTuple;
            TimeTuple.Item1 = stopwatch1;
            TimeTuple.Item2 = stopwatch2;
            return TimeTuple;
        }

    }
}
