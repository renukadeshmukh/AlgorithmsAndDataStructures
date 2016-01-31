using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    /*
     * Write a method to replace all spaces in a string with'%20'. You may assume that
     * the string has sufficient space at the end of the string to hold the additional
     * characters, and that you are given the "true" length of the string. (Note: if implementing
     * in Java, please use a character array so that you can perform this operation
     * in place.)
     * EXAMPLE
     * Input: "Mr John Smith     "
     * Output: "Mr%20Dohn%20Smith"
     */
    class P1_4
    {
        public string ReplaceAllSpacesInString(string input, int trueLen)
        {
            //1. start backwards
            //2. if space found copy %20 else just copy the current character at the end. 
            char[] charArr = input.ToCharArray();
            int j = input.Length-1;
            for (int i = trueLen; i > 0; i--)
            {
                if(charArr[i] == ' ')
                {
                    charArr[j--] = '0';
                    charArr[j--] = '2';
                    charArr[j--] = '%';
                }
                else
                {
                    charArr[j--] = charArr[i]; 
                }

            }

            return new string(charArr);
        }

        //static void Main(string[] args)
        //{

        //    P1_4 ras = new P1_4();
        //    string input = "Renuka Deshmukh, Indiana University      ";
        //    string result = ras.ReplaceAllSpacesInString(input, 34);
        //    Console.WriteLine(input);
        //    Console.WriteLine(result);
        //    Console.ReadKey();

        //}
    }
}
