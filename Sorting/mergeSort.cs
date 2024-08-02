using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class mergeSort
    {

        public int[] merge(int[] arr, int left, int mid, int right)
        {
            int size1 = mid - (left - 1);
            int size2 = right - mid;
            int[] leftArr = new int[size1];
            int[] rightArr = new int[size2];
            for (int i = 0; i < size1; i++) {
                leftArr[i] = arr[left+i];
            }
            for (int i = 0; i < size2; i++) { 
                rightArr[i] = arr[mid+1+i];
            
            }
            int x = 0;
            int y = 0;
            int k = left;

            while(x<size1 && y<size2)
            {
                if (leftArr[x] < rightArr[y])
                {
                    arr[k]=leftArr[x];
                    x++;
                }
                else
                {
                    arr[k] = rightArr[y];
                    y++;
                }
                k++;
            }
            while(x<size1)
            {
                arr[k] = leftArr[x];
                x++;
                k++;

            }
            while (y < size2) {
                arr[k] = rightArr[y];
                y++;
                k++;
            }

            return arr;
        }
        public int[] sort(int[] arr, int low,int high)
        {

            if(low==high) return new int[0];
            int mid= low + (high-low)/2;
            sort(arr, low, mid);
            sort(arr, mid+1, high);
            merge(arr, low, mid, high);

            return arr;
        }

        public static void Main(String[] args)
        {
            int[] arr = { 11, 2, 33, 40, 5, 61, 7, 81 };
            mergeSort sort = new mergeSort();
            arr = sort.sort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
