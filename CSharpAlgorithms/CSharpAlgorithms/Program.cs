using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

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

    public static class Algorithms
    {
        public static void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for(int i=0; i < partIndex; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        Utility.Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for(int partIndex = array.Length-1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;
                for(int i=1; i <= partIndex; i++)
                {
                    if(array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }

                Utility.Swap(array, largestAt, partIndex);
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int curUnsorted = array[partIndex];
                int i = 0;
                for (i = partIndex; i > 0 && array[i - 1] > curUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = curUnsorted;
            }
        }

        public static void ShellSort(int[] array)
        {
            int gap = 1;
            while(gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while(gap >= 1)
            {
                for(int i=gap; i<array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Utility.Swap(array, j, j - gap);
                    }
                }
                gap /= 3;
            }
        }

        //C# 7 allows for local functions
        public static void MergeSort(int[] array)
        {
            int[] aux = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if(high <= low)
                {
                    return;
                }

                //Right sub arrays will be bigger
                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1])
                {
                    return;
                }
                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, high - low + 1);

                for(int k=low; k<=high; k++)
                {
                    if(i > mid)
                    {
                        array[k] = aux[j++];
                    }
                    else if(j > high)
                    {
                        array[k] = aux[i++];
                    }
                    else if(aux[j] < aux[i])
                    {
                        array[k] = aux[j++];
                    }
                    else
                    {
                        array[k] = aux[i++];
                    }
                }
            }
        }

        public static void QuickSort(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                    return;

                int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);
            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = high+1;

                int pivot = array[low];
                while (true)
                {
                    while(array[++i] < pivot)
                    {
                        if (i == high)
                            break;
                    }
                    while(pivot < array[--j])
                    {
                        if (j == low)
                            break;
                    }

                    if (i >= j)
                        break;

                    Utility.Swap(array, i, j);
                }
                Utility.Swap(array, low, j);
                return j;
            }
        }
    }
}
