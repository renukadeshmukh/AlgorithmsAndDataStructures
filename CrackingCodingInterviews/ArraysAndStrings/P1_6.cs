using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterviews
{
    /*
    * Given an image represented by an NxN matrix, where each pixel in the image is
    * 4 bytes, write a method to rotate the image by 90 degrees. Can you do this in
    * place?
    */
    class P1_6
    {
        public void RotateMatrixBy90Degrees(int[,] matrix, Direction dir, int N)
        {
            //1. Get transpose of matrix
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }

            //2. if left, reverse column-wise
            if(dir == Direction.Left)
            {
                for (int j = 0; j < N; j++)
                {
                    int k = 0;
                    for (int i = N-1; i > k; i--)
                    {
                        int tmp = matrix[k, j];
                        matrix[k, j] = matrix[i, j];
                        matrix[i, j] = tmp;
                        k++;
                    }
                }
            }
            //3. if right, reverse row-wise
            else
            {
                for (int i = 0; i < N; i++)
                {
                    int k = 0;
                    for (int j = N - 1; j > k; j--)
                    {
                        int tmp = matrix[i, k];
                        matrix[i, k] = matrix[i, j];
                        matrix[i, j] = tmp;
                        k++;
                    }
                }
            }
            
        }

        public void PrintMatrix(int[,] matrix, int N)
        {
            Console.WriteLine("\n\nThe matrix is :: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    P1_6 rm = new P1_6();
        //    int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
        //    rm.PrintMatrix(matrix, 2);

        //    rm.RotateMatrixBy90Degrees(matrix, Direction.Left, 2);
        //    rm.PrintMatrix(matrix, 2);

        //    matrix = new int[,] { { 1, 2 }, { 3, 4 } };
        //    rm.RotateMatrixBy90Degrees(matrix, Direction.Right, 2);
        //    rm.PrintMatrix(matrix, 2);


        //    Console.ReadKey();
        //}

    }

    public enum Direction
    {
        Left,
        Right
    }
}
