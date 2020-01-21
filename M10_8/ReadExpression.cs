using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_8
{
    public class ReadExpression
    {
        public string AddSpace(string str)
        {
            string tmp = "";

            foreach (char item in str)
            {
                tmp += item + " ";
            }

            return tmp;
        }

        public string[] Read(string str)
        {
            string[] array = str.Split(' ');

            return array;
        }
      
    }
}
