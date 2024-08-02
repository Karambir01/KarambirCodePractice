using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recursion
{
    internal class CheckPalindrome
    {
        public bool checkPalindrome(string s, int left, int right) {
            
            if(left==right) return true;
            if (s[left] != s[right]) return false;
            checkPalindrome(s, left+1, right-1);
            return true;
        
        
        }

        //public static void Main(string[] args) { 
        
        //    CheckPalindrome checkPalindrome = new CheckPalindrome();
        //    string s = "racecardssd";
        //    bool result = checkPalindrome.checkPalindrome(s, 0, s.Length-1);
        //    Console.WriteLine(result);
        //    Console.ReadLine();

        //}
    }
}
