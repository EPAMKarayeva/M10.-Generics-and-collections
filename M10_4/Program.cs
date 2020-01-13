using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue customQueue = new CustomQueue();
            customQueue.Add("1");
            customQueue.Add(2);
            customQueue.Add(3);
            IIterator iterator = customQueue.CreateIterator();
            Console.WriteLine("Elements in queue:");

            while (iterator.Next())
            {
                var item = iterator.Current;
                Console.Write(item + " ");
            }

            Console.WriteLine("\nPick:" + customQueue.PickFirstQue());
            Console.WriteLine("Deleted element of queue:" + customQueue.DeleteFromQue());
            IIterator queIterator = customQueue.CreateIterator();
            Console.WriteLine("Elements after deleting from queue:");

            while (queIterator.Next())
            {
                var item = queIterator.Current;
                Console.Write(item + " ");
            }

          
            Console.ReadKey();

        }
    }
}
