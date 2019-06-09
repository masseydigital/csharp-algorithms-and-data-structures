using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public static class Utility
    {
        //Swaps out two values in an array
        public static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static bool Exists(int[] array, int number)
        {
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] == number)
                {
                    return true;
                }
            }

            return false;
        }

        public static int IndexOf(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
