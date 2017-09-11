using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSTest
{
    public interface IGridProductCalculator { long LargestProductOfNAdjacentIntegers(int[][] searchGrid, int adjacentIntegers); }
    public class GridProductCalculator : IGridProductCalculator
    {
        public long LargestProductOfNAdjacentIntegers(int[][] searchGrid, int adjacentIntegers)
        {
            long maxProduct = 0;
            int h = searchGrid.Length;
            int w = searchGrid[0].Length;
            //I treat the fixed dimension as giving the rows; the second as giving columns
            //NB It doesn't really matter, which is which!
            //first do verticals: max verticals given by (h-adjacentIntegers) * w
            for (int i = 0; i < h - adjacentIntegers; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    long product = 1;
                    for (int k = 0; k < adjacentIntegers; k++)
                    {
                        product *= searchGrid[i + k][j];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            //next do horizontals: max horizontals given by h * (w-adjacentIntegers)
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w - adjacentIntegers; j++)
                {
                    long product = 1;
                    for (int k = 0; k < adjacentIntegers; k++)
                    {
                        product *= searchGrid[i][j + k];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            //next do leading diagonal: max leading diagonal given by (h-adjacentIntegers) * (w-adjacentIntegers)
            for (int i = 0; i < h - adjacentIntegers; i++)
            {
                for (int j = 0; j < w - adjacentIntegers; j++)
                {
                    long product = 1;
                    for (int k = 0; k < adjacentIntegers; k++)
                    {
                        product *= searchGrid[i + k][j + k];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            //finally do trailing diagonal: max trailing diagonal given by (h-adjacentIntegers) * (w-adjacentIntegers)
            //note that we start in the adjacentIntegers'th column and decrement the columns
            for (int i = 0; i < h - adjacentIntegers; i++)
            {
                for (int j = adjacentIntegers - 1; j < w; j++)
                {
                    long product = 1;
                    for (int k = 0; k < adjacentIntegers; k++)
                    {
                        product *= searchGrid[i + k][j - k];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            return maxProduct;
        }
        public long LargestProductOfNAdjacentIntegersJW(int[,] searchGrid, int adjacentIntegers)
        {
            long maxProduct = 0;
            int h = searchGrid.GetLength(0);
            int w = searchGrid.GetLength(1);
            //I treat the fixed dimension as giving the rows; the second as giving columns
            //NB It doesn't really matter, which is which!
            //first do verticals: max verticals given by (h-adjacentIntegers) * w
            for (int i = 0; i < h - adjacentIntegers; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    long product = 1;
                    for (int k = 0; k < adjacentIntegers; k++)
                    {
                        product *= searchGrid[i + k, j];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            //next do horizontals: max horizontals given by h * (w-adjacentIntegers)
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w - adjacentIntegers; j++)
                {
                    long product = 1;
                    for (int k = 0; k < adjacentIntegers; k++)
                    {
                        product *= searchGrid[i, j + k];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            //next do leading diagonal: max leading diagonal given by (h-adjacentIntegers) * (w-adjacentIntegers)
            for (int i = 0; i < h - adjacentIntegers; i++)
            {
                for (int j = 0; j < w - adjacentIntegers; j++)
                {
                    long product = 1;
                    for (int k = 0; k < adjacentIntegers; k++)
                    {
                        product *= searchGrid[i + k, j + k];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            //finally do trailing diagonal: max trailing diagonal given by (h-adjacentIntegers) * (w-adjacentIntegers)
            //note that we start in the adjacentIntegers'th column and decrement the columns
            for (int i = 0; i < h - adjacentIntegers; i++)
            {
                for (int j = adjacentIntegers - 1; j < w; j++)
                {
                    long product = 1;
                    for (int k = 0; k < adjacentIntegers; k++)
                    {
                        product *= searchGrid[i + k, j - k];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            return maxProduct;
        }
    }
}
