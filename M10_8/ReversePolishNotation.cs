using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_8
{
    public class ReversePolishNotation
    {
        public void SortSymbols(string[] array, List<string> listOfOperands, List<string> listOfOperations)
        {
            List<string> symbolList = new List<string>();
            int first = 0, second;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "+" || array[i] == "-" || array[i] == "*" || array[i] == "/")
                {
                    var result = CheckPriorities(symbolList, array[i], i);

                    if (result == 1)
                    {
                        listOfOperands.Add(array[i]);
                        symbolList.Remove(symbolList[0]);
                    }
                    else
                    {
                        listOfOperations.Add(array[i]);
                        if (symbolList.Count > 1)
                        {
                            symbolList.Remove(symbolList[0]);
                        }
                    }
                }
                else
                {
                    listOfOperands.Add(array[i]);
                }
                if (array[i] == "(")
                {
                    listOfOperations.Add(array[i]);
                    first = listOfOperations.IndexOf(array[i]);
                }
                if (array[i] == ")")
                {
                    listOfOperations.Add(array[i]);
                    second = listOfOperations.IndexOf(array[i]);
                    PushBrackets(listOfOperations, listOfOperands, first, second);
                }

            }
            RemoveBrackets(listOfOperands);
            RemoveBrackets(listOfOperations);
        }

        public int CheckPriorities(List<string> symbolList, string str, int i)
        {

            symbolList.Add(str);

            if (symbolList.Count > 1)
            {

                if (symbolList[1] == "+" && (symbolList[0] == "-" || symbolList[0] == "+"))
                {
                    return 1;
                }

                if (symbolList[1] == "-" && (symbolList[0] == "-" || symbolList[0] == "+"))
                {
                    return 1;
                }

                if (symbolList[1] == "*" && (symbolList[0] == "/" || symbolList[0] == "*"))
                {
                    return 1;
                }

                if (symbolList[1] == "/" && (symbolList[0] == "/" || symbolList[1] == "*"))
                {
                    return 1;
                }

                return 2;
            }

            return 2;
        }

        public void PushBrackets(List<string> listOfOperations, List<string> listOfOperand, int first, int second)
        {
            for (int i = second-1; i > first; i--)
            {
                listOfOperand.Add(listOfOperations[i]);
                listOfOperations.RemoveAt(i);
            }

        }

        public void RemoveBrackets(List<string> list)
        {
            var tmp = list.Find(x => x == "(");
            list.Remove(tmp);
            var temp = list.Find(x => x == ")");
            list.Remove(temp);
        }


        public void Count(List<string> array, Stack<string> operations)
        {
            if (operations.Count > 0)
            {
                foreach (var item in operations)
                {
                    array.Add(item);
                }
            }

 
            Console.WriteLine("\nAfter:");

            foreach(var item in array)
            {
                Console.Write(item + "");
            }

            List<string> tmpArray = new List<string>();


            foreach (var item in array)
            {
                switch (item)
                {
                    case "+":
                        tmpArray[tmpArray.Count - 2] = tmpArray.ElementAt(tmpArray.Count - 2) + tmpArray.ElementAt(tmpArray.Count - 1);
                        // TODO: remove last
                        break;

                    case "-":

                        break;
                    case "*":

                        break;
                    case "/":
                       

                        break;
                    default:
                        tmpArray.Add(item);
                        break;
                }
            }

                //foreach (var item in array)
                //{
                //    switch (item)
                //    {
                //        case '+':
                //            resultNumber +
                //        break;
                //        default:
                //    }
                //}


            }

      
    }
}
