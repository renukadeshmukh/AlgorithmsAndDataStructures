using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.solution("dir1\n dir11\n dir12\n  picture.jpeg\n  dir121\n  file1.txt\ndir2\n file2.gif"));
            Console.ReadKey();
        }

        //int solution(int X)
        //{
        //    string xStr = X.ToString();
        //    char max = Char.MinValue;
        //    int maxIndx = 0;
        //    for (int i = 0; i < xStr.Length; i++)
        //    {
        //        if (xStr[i] > max)
        //        {
        //            max = xStr[i];
        //            maxIndx = i;
        //        }
        //    }

        //    string result = string.Concat(xStr.Substring(0, maxIndx + 1), xStr.Substring(maxIndx));
        //    return Int32.Parse(result);
        //}

        public int solution(string S)
        {
            // write your code in C#

            string[] dirs = S.Split('\n');
            List<int> paths = new List<int>();
            Dictionary<int, Stack<string> > dictionary= new Dictionary<int, Stack<string>>();
            foreach (var item in dirs)
            {
                int numSpaces = item.Length - item.TrimStart().Length;

                if(item.Contains(".gif") || item.Contains(".png") || item.Contains(".jpeg"))
                {
                    int i = 0;
                    string path = string.Empty;
                    while (i < numSpaces)
                    {
                        path = string.Concat(path,"/" , dictionary[i].Peek());
                        i++;
                    }
                    path = string.Concat(path, "/" , item.TrimStart());
                    paths.Add(path.Length);
                }
                else if(!item.Contains("."))
                {
                    if (dictionary.ContainsKey(numSpaces))
                        dictionary[numSpaces].Push(item.TrimStart());
                    else {
                        dictionary.Add(numSpaces, new Stack<string>());
                        dictionary[numSpaces].Push(item.TrimStart());
                    } 
                }
            }

            return paths.Max();  
        }
    }
}
