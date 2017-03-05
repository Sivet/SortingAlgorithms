using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSort
    {

        private void DoMergeSort(int[] notSorted, int left, int mid, int right)
        {
            int[] temp = new int[notSorted.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (notSorted[left] <= notSorted[mid])
                    temp[tmp_pos++] = notSorted[left++];
                else
                    temp[tmp_pos++] = notSorted[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = notSorted[left++];

            while (mid <= right)
                temp[tmp_pos++] = notSorted[mid++];

            for (i = 0; i < num_elements; i++)
            {
                notSorted[right] = temp[right];
                right--;
            }
        }
        public void RecursiveMergeSort(int[] notSorted, int left, int right)
        {
            int mid;

            if (left < right)
            {
                mid = (left + right) / 2;
                RecursiveMergeSort(notSorted, left, mid);
                RecursiveMergeSort(notSorted, mid + 1, right);

                DoMergeSort(notSorted, left, mid + 1, right);
            }
        }
    }
}
