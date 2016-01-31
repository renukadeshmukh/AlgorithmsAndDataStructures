using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews.ArraysAndStrings
{
    class P1_9
    {
        public bool IsPalinPossible(string input)
        {
            int checker = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                    checker ^= (1 << (input[i] - 'a'));
            }

            int antichecker = checker - 1;
            checker &= antichecker;

            if (checker == 0)
                return true;
            else return false;

        }

        //static void Main(string[] args)
        //{
        //    P1_9 obj = new P1_9();
        //    bool result = obj.IsPalinPossible("babacde");
        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}
    }
}
