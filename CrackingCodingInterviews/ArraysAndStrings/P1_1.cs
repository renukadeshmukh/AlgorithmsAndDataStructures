using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    /*
     * Implement an algorithm to determine if a string has all unique characters. What if 
     * you cannot use additional data structures
     */
    class P1_1
    {
        public bool IsUniqueCharsUsingArr(string input)
        {
            //there are only 256 possible ascii values
            bool[] ascii = new bool[256];
            for (int i = 0; i < input.Length; i++)
            {
                char a = input[i];
                if (ascii[a] == true)
                    return false;
                ascii[a] = true;
            }
            return true;
        }

        public bool IsUniqueCharsUsingHashMap(string input)
        {
            //map mainstains all unique characters only 
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (charMap.ContainsKey(input[i]))
                    return false;
                charMap.Add(input[i], 1);
            }
            return true;
        }


        //This method does not differentiate between capital and small letters. 
        //Use this method only when all chars are in single case. 
        public bool IsUniqueCharsUsingBitwise(string input)
        {
            int checker = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((checker & (1 << input[i])) > 0)
                    return false;

                checker |= (1 << input[i]);

            }
            return true;

        }

        //static void Main(string[] args)
        //{
        //    P1_1 uniqueChars = new P1_1();
        //    string input = "Hello";
        //    Console.WriteLine(uniqueChars.IsUniqueCharsUsingArr(input));
        //    Console.WriteLine(uniqueChars.IsUniqueCharsUsingHashMap(input));
        //    Console.WriteLine(uniqueChars.IsUniqueCharsUsingBitwise(input));
        //    Console.ReadKey();

        //}
    }
}
