using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recursion
{
    internal class FibonacchiSeries
    {
        public int fibonacchiSeries(int number)
        {
            if(number==1 || number==0)
            {
                return number;
            }

            int last= fibonacchiSeries(number-1);
            int secondLat= fibonacchiSeries(number-2);
            return last+secondLat;
        }
        public static void Main(string[] args)
        {
            FibonacchiSeries fibonacchiSeries = new FibonacchiSeries();
            int result = fibonacchiSeries.fibonacchiSeries(6);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
