using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class inserationSort
    {
        // Best and Worst time complexity O(n2)
        public void Sort(int[] arr) {

            for (int i = 1; i < arr.Length; i++) {
                
                int j= i;
                //ascending order
                while (j > 0 && arr[j] < arr[j-1] )
                { 
                    int temp = arr[j];
                    arr[j] = arr[j-1];
                    arr[j-1] = temp;
                    j--;
                
                }
                //descending order
                //while (j > 0 && arr[j] < arr[j - 1])
                //{
                //    int temp = arr[j];
                //    arr[j] = arr[j - 1];
                //    arr[j - 1] = temp;
                //    j--;

                //}


            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        
        
        }

        public static void Main(string[] args)
        {

            int[] arr = { 11, 2, 33, 40, 5, 61, 7, 81 };
            inserationSort sort = new inserationSort();
            sort.Sort(arr);
            Console.ReadLine();


        }
    }

}
