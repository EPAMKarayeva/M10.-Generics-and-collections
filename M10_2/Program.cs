using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Test.txt";

            FileReading file = new FileReading();
            Console.WriteLine("Count of words:"+file.ReadFile(path));

            Console.ReadKey();
        }
    }
}
