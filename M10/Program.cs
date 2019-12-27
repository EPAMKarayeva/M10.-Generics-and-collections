using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 15);
            }

            int temp;

            for (int i = 1; i < array.Length; i++)
            {
                for(int j=i; j>0 && array[j-1]>array[j]; j--)
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nEnter needed number:");
            int n = Convert.ToInt32(Console.ReadLine());
           
            BinarySearch binarySearch = new BinarySearch();
            Console.WriteLine("Result: "+binarySearch.BinarySearching<int>(n, array));
            Console.ReadKey();
        }
    }
}
