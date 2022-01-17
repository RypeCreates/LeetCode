
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class PascalsTriangle
    {
        public static List<List<int>> Generate(int numRows)
        {
            // iterative

            var triangle = new List<List<int>>();

       
            if (numRows > 0)
            {
                triangle.Add(new List<int>() { 1 });
            }
            if (numRows > 1)
            {
                triangle.Add(new List<int>() { 1, 1 });
            }
            if (numRows < 3) return triangle;

            var lastRow = triangle[1];
            // now starting at row 3, do addition to populate the 
            for (int i = 3; i <= numRows; i++)
            {
                var row = new List<int>();

                // for each column in the 
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(lastRow[j - 1] + lastRow[j]);
                    }
                }

                triangle.Add(row);
                lastRow = row;
            }


            return triangle;
        }

        public static IList<IList<int>> GenerateWithArrays(int numRows)
        {
            // iterative

            var triangle = new int[numRows][];


            if (numRows > 0)
            {
                triangle[0] = new int[] { 1 };
            }
            if (numRows > 1)
            {
                triangle[1] = new int[] { 1, 1 };
            }
            if (numRows < 3) return triangle;

            var lastRow = triangle[1];

            // now starting at row 3, do addition to populate the 
            for (int i = 2; i < numRows; i++)
            {
                var row = new int[i + 1];

                // for each column in the 
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row[j] = 1;
                    }
                    else
                    {
                        row[j] = lastRow[j - 1] + lastRow[j];
                    }
                }

                triangle[i] = row;
                lastRow = row;
            }


            return triangle;
        }

    }

}
