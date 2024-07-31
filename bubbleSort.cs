using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class bubbleSort
    {
        // Worst and Average time complexity O(n2);
        // Best time complexity O(n)
        public void Sort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                bool isSwapped=false;
                for(int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                        isSwapped=true;
                    }

                }
                if(!isSwapped)
                {
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            


        }


        public static void Main(string[] args)
        {
            int[] arr = { 11, 2, 33, 40, 5, 61, 7, 81 };
            bubbleSort sort = new bubbleSort();
            sort.Sort(arr);
            Console.ReadLine();
        }
    }
}
