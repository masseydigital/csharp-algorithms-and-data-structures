using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class Searching
    {
        public static int RecursiveBinarySearch(int[] array, int value)
        {
            return InternalRecursiveBinarySearch(0, array.Length);
            int InternalRecursiveBinarySearch(int low, int high)
            {
                if(low >= high)
                {
                    return -1;
                }

                int mid = (low + high) / 2;

                if(array[mid] == value)
                {
                    return mid;
                }

                if(array[mid] < value)
                {
                    return InternalRecursiveBinarySearch(mid + 1, high);
                }

                return InternalRecursiveBinarySearch(low, mid);
            }
        }

        public static int BinarySearch(int[] array , int value)
        {
            int low = 0;
            int high = array.Length;

            while(low < high)
            {
                int mid = (low + high) / 2;

                if(array[mid] == value)
                {
                    return mid;
                }

                if(array[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return -1;
        }
    }
}
