using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    /*
    * Write an algorithm such that if an element in an MxN matrix is 0, its entire row
    * and column are set to 0.
    */
    class P1_7
    {
        public void ConvertRowAndColToZeroes(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            //1. set to store the row and column number
            HashSet<int> zeroRows = new HashSet<int>();
            HashSet<int> zeroCols = new HashSet<int>();

            //2. Save the row and column number which has a zero element
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        zeroRows.Add(i);
                        zeroCols.Add(j);
                    }
                }
            }

            //3. for every row num in the zeroRows set, set all elements to zero  
            foreach (var i in zeroRows)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            //4. for every col num in the zeroCols set, set all elements to zero  
            foreach (var j in zeroCols)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        public void PrintMatrix(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            Console.WriteLine("\n\nThe matrix is :: ");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    P1_7 rm = new P1_7();
        //    int[,] matrix = new int[,] { { 0, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
        //    rm.PrintMatrix(matrix);

        //    rm.ConvertRowAndColToZeroes(matrix);
        //    rm.PrintMatrix(matrix);



        //    Console.ReadKey();
        //}
    }
}
