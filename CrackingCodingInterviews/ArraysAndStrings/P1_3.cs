using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    class P1_3
    {
        /*
         * Given two strings, write a method to decide if one is a permutation of the other.
         */
        public bool IsPermutation(string str1, string str2)
        {
            //1. if length of the 2 strings are not equal, they are not permutation
            if (str1.Length != str2.Length)
                return false;

            //2. Build a dictionary for str1 => chars and their count 
            Dictionary<char, int> charMap = new Dictionary<char, int>();  
            for (int i = 0; i < str1.Length; i++)
            {
                if (charMap.ContainsKey(str1[i]))
                    charMap[str1[i]]++;
                else charMap.Add(str1[i], 1);
            }

            //3.1 if char in str2 not present in str1, return false
            //3.2 if char present in str1, decrement count
            for (int i = 0; i < str2.Length; i++)
            {
                if (!charMap.ContainsKey(str2[i]))
                    return false;
                else if (charMap[str2[i]] == 0)
                    return false;
                else charMap[str2[i]]--;
            }

            //4. check if resutling count of all chars in str1 is 0. if yes, return true.
            foreach(var keyvalue in charMap){
                if (keyvalue.Value != 0)
                    return false;
            }
            return true;
        }

        //static void Main(string[] args)
        //{
        //    P1_3 sp = new P1_3();
        //    bool result = sp.IsPermutation("aabbcc", "abcabc");
        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}
    }
}
