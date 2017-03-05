using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class InsertionSorting
    {
        public int[] DoInsertionSort(int[] notSorted)
        {
            int temp, index;
            for (int i = 1; i < notSorted.Length; i++)
            {
                temp = notSorted[i];
                index = i - 1;

                while (index >= 0 && notSorted[index] > temp)
                {
                    notSorted[index + 1] = notSorted[index];
                    index--;
                }

                notSorted[index + 1] = temp;
            }
            return notSorted;
        }
    }
}
