using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_2
{
    public class FileReading
    {

        public int ReadFile(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string str = " ";
                    int count = 0;

                    while ((str = file.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                        count = CountWords(str);
                       
                    }

                    file.Close();

                    return count;
                }
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg);

                return 0;
            }
        }

        public int CountWords(string str)
        {
            int count = 0;
            string[] words = str.Split(' ', '.', '-', ':', '?', '!');
            List<string> list = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    list.Add(words[i]);
                    count++;
                }
            }

            return count;

        }
    }
}
