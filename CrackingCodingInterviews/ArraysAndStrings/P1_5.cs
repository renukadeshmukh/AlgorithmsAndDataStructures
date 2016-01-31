using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    /*
     * Implemen t a method t o perform basi c string compression using the counts 
     * of repeated characters. For example, the string aabcccccaaa would become a2blc5a3. 
     * I f the "compressed" string would no t become smaller than the original string, 
     * your method should return the original string. 
     */
    class P1_5
    {
        public string CompressString(string input){

            char letter = input[1];
            int count = 0;
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
			{
                if (letter == input[i])
                    count++;
                else
                {
                    result = result + letter + count;
                    letter = input[i];
                    count = 1;
                }
			}
            result = result + letter + count;
            if (result.Length > input.Length)
                result = input;
            return result;
        }

        //static void Main(string[] args)
        //{
        //    P1_5 cs = new P1_5();
        //    string input = "aabcccccaaa";
        //    string compressed = cs.CompressString(input);
        //    Console.WriteLine(compressed);

        //     input = "aabbcc";
        //     compressed = cs.CompressString(input);
        //    Console.WriteLine(compressed);
        //    Console.ReadKey();
        //}
    }
}
