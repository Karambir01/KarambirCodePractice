using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recursion
{
    internal class ReverseArray
    {
        // two pointer
        //public int[] reverseArray(int[] array, int left,int right)
        //{

        //    //iterative approach

        //    //while (left <= right) {
        //    //    int temp = array[left];
        //    //    array[left] = array[right];
        //    //    array[right] = temp;
        //    //    left++;
        //    //    right--;
        //    //}

        //    if (left >= right) { 
        //       // return new int[] {};
        //       return array;

        //    }
        //    int temp=array[left];
        //    array[left]=array[right];
        //    array[right]=temp;

        //    reverseArray(array, left+1, right-1);

        //    return array;

        //}

        //single pointer
        public int[] reverseArray(int[] array, int left)
        {
            
            if(left>=array.Length-1)
            {
                return array;
            }

            int temp= array[left];
            array[left]= array[array.Length-1-left];
            array[array.Length-1-left]= temp;
            reverseArray(array, left+1);
            return array;
        }
        //public static void Main(string[] args) {

        //    // int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //    int[] array = { 9,8,7,6,5,7 };
        //    ReverseArray reverseArray = new ReverseArray();
        //    //before reverse
        //    Console.WriteLine("before reverse");
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);

        //    }

        //   // array =reverseArray.reverseArray(array, 0, array.Length-1);
        //   array = reverseArray.reverseArray(array, 0);
        //    // after reverse
        //    Console.WriteLine("after reverse");
        //    for (int i = 0; i < array.Length; i++) {
        //        Console.WriteLine(array[i]);

        //    }
        //    Console.ReadLine();
        
        
        //}
    
    
    }
}
