using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recursion
{
    internal class ReverseString
    {
        public char[] reverseString(char[] name, int left, int right) {
            if(left>=right) return name;

            char c = name[left];
            name[left] = name[right];
            name[right] = c;
            reverseString(name, left+1, right-1);
            return name;
        
        }

        //public static void Main(string[] args) {

        //    ReverseString reverseString = new ReverseString();
        //    string s = "karambir";
        //    Console.WriteLine("before reverse  "+s);
        //    char[] a = s.ToCharArray();
        //    a = reverseString.reverseString(a, 0, s.Length - 1);
        //    string news = "";
        //    for (int i = 0; i < a.Length; i++) {

        //        news += a[i];
        //    }
        //    Console.WriteLine("After reverse "+news);

        //    Console.ReadLine();


        //}
    }
}
