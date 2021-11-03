using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberSort1 = new List<int>();
            numberSort1.Add(3);
            numberSort1.Add(10);
            numberSort1.Add(41);
            numberSort1.Add(32);
            numberSort1.Add(27);
            numberSort1.Add(25);
            numberSort1.Add(21);
            numberSort1.Add(99);
            numberSort1.Add(8);
            SortArray(numberSort1);
            Print(numberSort1);

            List<int> numberSort2 = new List<int>();
            numberSort2.Add(21);
            numberSort2.Add(16);
            numberSort2.Add(18);
            SortArray(numberSort2);
            Print(numberSort2);


            List<int> numberSort3 = new List<int>();
            numberSort3.Add(5);
            numberSort3.Add(7);
            numberSort3.Add(3);
            SortArray(numberSort3);
            Print(numberSort3);

            List<int> numberSort4 = new List<int>();
            numberSort4.Add(52);
            numberSort4.Add(51);
            numberSort4.Add(45);
            SortArray(numberSort4);
            Print(numberSort4);


        }

        static void Print(List<int> numberSort)
        {
            Console.Write("This is your sorted list: ");
            for (int i = 0; i < numberSort.Count; i++)
                Console.Write(numberSort[i] + " ");
            Console.WriteLine();
        }

        public static void SortArray(List<int> numberSort)
        {
            Console.Write("This is your unsorted list: ");
            foreach(var v in numberSort)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
            int n = numberSort.Count;
            int temp = 0;

            for (int i = 0; i < n; i++)

            {
                for (int j = 1; j < (n - i); j++)
                {
                    if(numberSort[j-1] > numberSort[j])
                    {
                        temp = numberSort[j - 1];
                        numberSort[j - 1] = numberSort[j];
                        numberSort[j] = temp;
                    }
                }
            }
        }
    }
}
