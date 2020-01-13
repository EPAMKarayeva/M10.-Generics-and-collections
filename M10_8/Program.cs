using System;
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
            var array = readExpression.Read(str);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+"-");
            }

            Console.ReadKey();
        }
    }
}
