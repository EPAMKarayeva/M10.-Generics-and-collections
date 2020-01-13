using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack customStack = new CustomStack();
            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            IIterator iterator = customStack.CreateIterator();
            Console.WriteLine("Elements in stack:");

            while (iterator.Next())
            {
                var item = iterator.Current;
                Console.Write(item + " ");
            }

            Console.WriteLine("\nPick:" + customStack.Pick());
            Console.WriteLine("Deleted element of stack:" + customStack.Pop());
            IIterator stackIterator = customStack.CreateIterator();
            Console.WriteLine("Elements after deleting from stack:");

            while (stackIterator.Next())
            {
                var item = stackIterator.Current;
                Console.Write(item + " ");
            }


            Console.ReadKey();
        }
    }
}
