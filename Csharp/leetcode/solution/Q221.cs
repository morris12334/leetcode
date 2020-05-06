using System;
using System.Linq;

namespace leetcode.solution._2020April
{
    class Q221
    {
        public int MaximalSquare(char[][] matrix)
        {
            int output = 0;
            int yLength = matrix.Count();
            if (yLength == 0) return output;
            int xLength = matrix[0].Count();

            if (xLength == 0) return output;
            int minLength = Math.Min(xLength, yLength);


            bool bol = true;

            for (int sideL = 1; sideL <= minLength; sideL++)
            {
                for (int x = 0; x <= xLength - sideL; x++)
                {
                    for (int y = 0; y <= yLength - sideL; y++)
                    {
                        bol = true;

                        for (int xx = 0; xx < sideL; xx++)
                        {
                            for (int yy = 0; yy < sideL; yy++)
                            {
                                if (matrix[y + yy][x + xx] == '0')
                                {
                                    bol = false;
                                    break;
                                }
                            }
                            if (!bol) break;
                        }

                        if (bol) output = (sideL) * (sideL);

                        /*
                        if (!bol)
                            continue;
                        else
                        {
                            for (int yy = 0 + 1; yy <= sideL - 1; yy++)
                            {
                                string log7 = (y + yy) + " " + (x) + " =>" + matrix[y + yy][x];
                                string log8 = (y + yy) + " " + (x + sideL) + " =>" + matrix[y + yy][x + sideL];

                                if (matrix[y + yy][x] == '0' || matrix[y + yy][x + sideL] == '0')
                                {
                                    bol = false;
                                    break;
                                }
                            }
                        }
                        */


                        /*

                        for (int xx = 0; xx <= sideL; xx++)
                        {
                            string log5 = y + " " + (x + xx) + " =>" + matrix[y][x + xx];
                            string log6 = (y + sideL) + " " + (x + xx) + " =>" + matrix[y + sideL][x + xx];

                            if (matrix[y][x + xx] == '0' || matrix[y + sideL][x + xx] == '0')
                            {
                                bol = false;
                                break;
                            }
                        }

                        if (!bol)
                            continue;
                        else
                        {
                            for (int yy = 0 + 1; yy <= sideL - 1; yy++)
                            {
                                string log7 = (y + yy) + " " + (x) + " =>" + matrix[y + yy][x];
                                string log8 = (y + yy) + " " + (x + sideL) + " =>" + matrix[y + yy][x + sideL];

                                if (matrix[y + yy][x] == '0' || matrix[y + yy][x + sideL] == '0')
                                {
                                    bol = false;
                                    break;
                                }
                            }
                        }

                        if (matrix[y][x] == '1')
                            if (matrix[y + sideL][x] == '1')
                                if (matrix[y][x + sideL] == '1')
                                    if (matrix[y + sideL][x + sideL] == '1')
                                        output = sideL * sideL;
                                        */
                    }
                }
            }
            return output;
        }

        private static char[][] MatrixTranspose(char[][] matrix)
        {
            /*
            //正當性檢討
            if (!isMatrix(matrix))
            {
                throw new Exception("matrix 不是一個矩陣");
            }
            //矩陣中沒有元素的情形
            if (matrix.Length == 0)
            {
                return new char[][] { };
            }
            */

            char[][] result = new char[matrix[0].Length][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new char[matrix.Length];
            }
            //新矩陣生陳規則： b[i,j]=a[j,i]
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[0].Length; j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }
            return result;
        }

    }
}
