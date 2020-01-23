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
                    var result = CheckPriorities(symbolList, array[i], listOfOperations);

                    if (result == 1)
                    {
                        listOfOperands.Add(listOfOperations[listOfOperations.Count - 2]);
                        listOfOperations.RemoveAt(listOfOperations.Count - 2);
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

        public int CheckPriorities(List<string> symbolList, string str, List<string> list)
        {

            list.Add(str);

            if (list.Count >= 2)
            {

                if (list[list.Count-1] == "+" && (list[list.Count - 2] == "-" || list[list.Count - 2] == "+" || list[list.Count - 2] =="*" || list[list.Count - 2] == "/"))
                {
                    return 1;
                }

                if (list[list.Count - 1] == "-" && (list[list.Count - 2] == "-" || list[list.Count - 2] == "+" || list[list.Count - 2] == "*" || list[list.Count - 2] == "/"))
                {
                    return 1;
                }

                if (list[list.Count - 1] == "*" && (list[list.Count - 2] == "/" || list[list.Count - 2] == "*"))
                {
                    return 1;
                }

                if (list[list.Count - 1] == "/" && (list[list.Count - 2] == "/" || list[list.Count - 2] == "*"))
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
            var tmp = list.FindAll(x => x == "(");

            foreach (var item in tmp)
            {
                list.Remove(item);
            }

            var temp = list.FindAll(x => x == ")");

            foreach (var item in temp)
            {
                list.Remove(item);
            }
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
                        tmpArray.RemoveAt(tmpArray.Count - 1);
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

            }

      
    }
}
