using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Best, average, worst time complexity nlogn;
    internal class quickSort
    {
        public int Sort(int[] arr, int low, int high) { 

            int pivot=arr[low];
            int i = low;
            int j= high;

            while (i <j) {

                while (arr[i] <= pivot && i <= high) { 
                    i++;
                
                }
                while(arr[j] > pivot && j >= low)
                {
                    j--;
                }
                if (i < j)
                {
                    int temp= arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                }
            }

            //int temp1 = pivot;
            arr[low] = arr[j];
            arr[j]=pivot;

            return j;


        
        }

        public int[] findPivot(int[] arr, int low, int high) {

            if (low < high) {

                int pivot = Sort(arr,low,high);
                findPivot(arr, low, pivot-1);
                findPivot(arr, pivot+1,high);
            
            }
            return arr;
        
        }

        public static void Main(string[] args)
        {


            int[] arr = { 11, 2, 33, 40, 5, 61, 7, 81 };
            quickSort sort = new quickSort();
            arr = sort.findPivot(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();

        }

    }
}
