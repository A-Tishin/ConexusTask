using System;
using System.Linq;

namespace ConexusTask
{
    public class Program
    {
        static void Main(String[] args)
        {
        }


        // True if 0 or Power of 2 (2, 8, 128...) 
        public static bool IsPowerOfTwo(int num)
        {
            return (num & (num - 1)) == 0;
        }

        // Gets the count of 1 in binary form of num
        public static int CountOne(int num)
        {
            int count = 0;
            while (num != 0)
            {
                num = num & (num - 1);
                count++;
            }

            return count;
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
