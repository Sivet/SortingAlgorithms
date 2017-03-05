using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        Random random = new Random();
        int[] notSorted = new int[10];
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            //myProgram.TryInsertionSort();
            //myProgram.TryQuickSort();
            myProgram.TryMergeSort();
        }
        public void TryInsertionSort()
        {
            InsertionSorting Insertion = new InsertionSorting();
            
            for (int i = 0; i < notSorted.Length; i++)
            {
                int value = random.Next(1, 5000);
                notSorted[i] = value;
            }
            Insertion.DoInsertionSort(notSorted);

            Console.WriteLine("==========Integer Array OutPut===============");
            for (int i = 0; i < notSorted.Length; i++)
            {
                Console.WriteLine(notSorted[i]);
            }
            Console.ReadKey();
        }
        public void TryQuickSort()
        {

        }
        public void TryMergeSort()
        {
            MergeSort Merging = new MergeSort();

            for (int i = 0; i < notSorted.Length; i++)
            {
                int value = random.Next(1, 5000);
                notSorted[i] = value;
            }
            Merging.RecursiveMergeSort(notSorted, 0, notSorted.Length - 1);
            Console.WriteLine("==========Integer Array OutPut===============");
            for (int i = 0; i < notSorted.Length; i++)
            {
                Console.WriteLine(notSorted[i]);
            }
            Console.ReadKey();
        }
    }
}
