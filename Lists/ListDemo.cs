using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_CSharp_Course
{
    public class Customer{
        public string Name {get; set;}
        public DateTime BirthData {get; set;}
    }

    public class ListDemo
    {
        public static void Run()
        {
            List<int> list = new List<int>();
            LogCountAndCapacity(list);

            for(int i=0; i<16; i++){
                list.Add(i);
                LogCountAndCapacity(list);
            }

            for(int i=10; i>0; i--){
                list.Remove(i-1);
                LogCountAndCapacity();
            }

            list.TrimExcess();
            LogCountAndCapacity(list);

            list.Add(1);
            LogCountAndCapacity(list);

            Console.Read();
        }

        private static void LogCountAndCapacity(List<int> list){
            Console.WriteLine($"Count = {list.Count}. Capacity={list.Capacity}");
        }
    }

    public static void ApiMember(){
        var list = new List<int>(){1,0,5,3,4};
        list.Sort();

        int indexBinSearch = list.BinarySearch(3);

        list.Reverse();

        ReadOnlyCollection<int> readOnlyList = list.AsReadOnly();

        int[] array = list.ToArray();
        
        var listCustomers = new List<Customer>{
            new Customer{BirthDate = new DateTime(1988, 1, 2), Name = "Elias"},
            new Customer{BirthDate = new DateTime(1995, 4, 11), Name = "Maria"},
            new Customer{BirthDate = new DateTime(1992, 3, 25), Name = "Ann"}
        };

        listCustomers.Sort((left, right) =>{
            if(left.BirthData > right.BirthData)
            {
                return 1;
            }
            if(right.BirthData > left.BirthData){
                return -1;
            }
            return 0;
        });
    }
}