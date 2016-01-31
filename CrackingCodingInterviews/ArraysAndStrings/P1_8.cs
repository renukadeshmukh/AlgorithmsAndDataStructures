using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    /*
    Assume you have a method isSubstring which checks if one word is a
    substring of another. Given two strings, si and s2, write code to check if s2 is
    a rotation of si using only one call to isSubstring (e.g.,"waterbottle"is a rotation
    of "erbottlewat").
        */
    class P1_8
    {
        public bool IsRotation(string s1, string s2)
        {
            string s1s1 = string.Concat(s1, s1);
            if (s1s1.Contains(s2))
                return true;
            else return false;
        }

        //static void Main(string[] args)
        //{
        //    P1_8 ir = new P1_8();
        //    string s1 = "waterbottle";
        //    string s2 = "erbottlewat";
        //    bool result = ir.IsRotation(s1, s2);
        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}


    }
}
