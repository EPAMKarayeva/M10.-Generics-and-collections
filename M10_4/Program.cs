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
            List<int> list = new List<int>();
            list.AddToQue<Int32>(1);
            list.AddToQue<Int32>(2);
            list.AddToQue<Int32>(3);
            list.AddToQue<Int32>(4);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pick:"+list.PickFirstQue());
            List<string> listStr = new List<string>();
            listStr.AddToQue<string>("hi");

            foreach (var item in listStr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
