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
        public string[] Read(string str)
        {
            string[] array = str.Split(' ');

            return array;
        }

        public void SortSymbols(string[] array)
        {
            ArrayList listOfOperands = new ArrayList();
            ArrayList listOfOperations = new ArrayList();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "+" || array[i] == "-" || array[i] == "*" || array[i] == "/")
                {

                    listOfOperations.Add(array[i]);
                }

            }

        }

        //switch or if operator for cheking piority(bool)
        public void CheckPriorities(string[] array, int n)
        {
            


        }

        public int ConvertInInt(string str)
        {
            var n = Convert.ToInt32(str);

            return n;
        }
    }
}
