using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            InsertionSorting Insertion = new InsertionSorting();
            
            int[] notSorted = new int[10];
            int[] Sorted = new int[10];

            for (int i = 0; i < notSorted.Length; i++)
            {
                int value = random.Next(1, 5000);
                notSorted[i] = value;
            }
            Insertion.Sort(notSorted);

            Console.WriteLine("==========Integer Array OutPut===============");
            for (int i = 0; i < notSorted.Length; i++)
            {
                Console.WriteLine(notSorted[i]);
            }
            Console.ReadKey();
        }
    }
}
