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
    }
}
