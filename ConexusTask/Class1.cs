using System;
using System.Linq;

namespace ConexusTask
{
    public class Program
    {
        static void Main(String[] args)
        {
        }
        
        public static bool IsPowerOfTwo(int num)
        {
            return (num & (num - 1)) == 0;
        }
        
        public static void ZeroesToEnd(int[] arr)
        {
            int numToShift = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    continue;

                arr[numToShift] = arr[i];
                numToShift++;
            }

            for (var i = numToShift; i < arr.Length; i++)
                arr[i] = 0;
        }
        
        public static int GetIndexOfMedian(int[] arr)
        {
            var sum = arr.Sum();
            var acc = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                acc += arr[i];
                if (acc >= sum / 2) return i;
            }

            return arr.Length;
        }
    }
}
