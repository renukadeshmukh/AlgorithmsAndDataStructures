using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    /*
     * Implement a function void reversefchar* str) in Cor C++ which reverses a null-terminated string.
     */
    class P1_2
    {
        public string InputString { get; set; }
        public void ReverseString(P1_2 rsc)
        {
            string input = rsc.InputString;
            rsc.InputString = string.Empty;
            for (int i = input.Length; i > 0; i--)
            {
                rsc.InputString = string.Concat(rsc.InputString, input[i - 1]);
            }
            
           
        }

        //static void Main(string[] args)
        //{
        //    P1_2 rsc = new P1_2() { InputString = "Renuka" };
        //    rsc.ReverseString(rsc);
        //    Console.WriteLine(rsc.InputString);

        //    Console.ReadKey();
        //}
    }
}
