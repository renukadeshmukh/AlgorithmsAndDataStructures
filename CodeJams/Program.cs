using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJams
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.solution(12511));
            Console.ReadKey();
        }

        int solution(int X)
        {
            string xStr = X.ToString();
            char max = Char.MaxValue;
            int maxIndx = 0;
            for (int i = 0; i < xStr.Length; i++)
            {
                if (xStr[i] > max)
                {
                    max = xStr[i];
                    maxIndx = i;
                }
            }

            xStr = xStr.Substring(0, maxIndx) + xStr[maxIndx] + xStr.Substring(maxIndx + 1, xStr.Length);
            return Int32.Parse(xStr);
        }
    }
}
