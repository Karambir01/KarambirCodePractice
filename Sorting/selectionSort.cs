using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class selectionSort
    {

        public void Sort(int[] arr) {

            for (int i = 0; i < arr.Length; i++) { 
                int minIndex=i;

                for (int j = i + 1; j < arr.Length; j++) { 

                    if(arr[j] <arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

            }
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }

            

        }

        public static void Main(string[] args)
        {
            int[] arr = { 11, 2, 33, 40, 5, 61, 7, 81 };
            selectionSort sort = new selectionSort();
            sort.Sort(arr);
            Console.ReadLine();
        }
    }
}
