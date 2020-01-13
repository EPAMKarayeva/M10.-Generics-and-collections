using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            int n = Convert.ToInt32(Console.ReadLine());
            FibonacciRow fibonacci = new FibonacciRow();
            var fibRow = fibonacci.CountNumbers(n);

            foreach (int item in fibRow)
            {   if (item > 0)
                {
                    Console.Write(item + " ");
                }
                else
                {
                    Console.WriteLine("Limit");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
