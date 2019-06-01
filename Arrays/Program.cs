using System;

namespace Algorithms_CSharp_Course
{
    static void Main(string[] args)
    {
        //ArraysDemo();
        //TestOneBasedArray();
        ListDemo.Run();
    }

    static void ArrayTimeComplexity(object[] array)
    {
        //access by index O(1)
        Console.WriteLine(array[0]);

        int length = array.Length;
        object searchedElement = new object();

    //searching for an element takes O(N)
        for(int z=0; z<length; z++)
        {
            if(array[z] == searchedElement)
            {
                Console.WriteLine("Exists!");
            }
        }

        //add to a full array
        var bigArray = new int[length * 2];
        Array.Copy(array, bigArray, length);
        bigArray[length + 1] = 10;

        //add to the end of an array when there's some space
        //O(1)
        array[length-1] = 10;

        //Remove an element by assigning null: O(1)
        array[6] = null;
    }

    private static void RemoveAt(object[] array, int index)
    {
        //There is a hidden for loop inside of Array.Copy
        var newArray = new object[array.Length - 1];
        Array.Copy(array, 0, newArray, 0, index);
        Array.Copy(array, index+1, newArray, index, array.Length-1-index);
    }

    private static void ArraysDemo(){
        int[] a1;
        a1 = new int[10];

        int[] a2 = new int[5];

        int[] a3 = new int[5] {1,2,3,3,5};
        
        int[] a4 = {1,2,3,4,5};

        for(int k=0; k<a3.Length; k++){
            Console.WriteLine($"{a3[i]}");
        }

        Console.WriteLine();

        foreach (var el in a4){
            Console.WriteLine($"{el}");
        }

        Console.WriteLine();

        Array myArray = new int[5];

        Array myArray2 = Array.CreateInstance(typeof(int), 5);
        myArray2.SetValue(1,0);

        Console.Read();
    }

    private static void TestOneBasedArray(){
        //Create an array of 4 elements with a start index of 1
        Array myArray = Array.CreateInstance(typeof(NotImplementedException), new[] {4}, new[] {1});
        myArray.SetValue(2019, 1);
        myArray.SetValue(2020, 2);
        myArray.SetValue(2021, 3);
        myArray.SetValue(2022, 4);

        Console.WriteLine($"Starting index is: {myArray.GetLowerBound(0)}");
        Console.WriteLine($"Ending index is: {myArray.GetUpperBound(0)}");

        //for(int x=myArray.GetLowerBound(0); i<= myArray.GetUpperBound(0); x++);

        for(int z=1; z<5; z++)
        {
            Console.WriteLine($"{myArray.GetValue(z)} at index {z}");
        }
    }
}
