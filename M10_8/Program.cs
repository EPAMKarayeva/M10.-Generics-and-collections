using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadExpression readExpression = new ReadExpression();

            string str = Console.ReadLine();
            var temp=readExpression.AddSpace(str);
            var array = readExpression.Read(temp);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            List<string> arrayList = new List<string>();
            List<string> list = new List<string>();
            Console.WriteLine("\nOperands:");

            ReversePolishNotation reversePolishNotation = new ReversePolishNotation();

            reversePolishNotation.SortSymbols(array, arrayList, list);

            foreach (string item in arrayList)
            {
                Console.Write(item + " ");
            
            }

            Console.WriteLine("\nOperations:");

            foreach (string item in list)
            {
                Console.Write(item + " ");

            }

            Stack<string> stack = new Stack<string>();
            
            foreach(var item in list)
            {
                stack.Push(item);
            }
            reversePolishNotation.Count(arrayList, stack);

            Console.ReadKey();
        }
    }
}
