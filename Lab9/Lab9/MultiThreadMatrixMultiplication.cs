using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab9
{
    class MultiThreadMatrixMultiplication
    {
        private Matrix first, second, result;
        public MultiThreadMatrixMultiplication(Matrix first, Matrix second, Matrix result)
        {
            this.First = first;
            this.Second = second;
            this.Result = result;
        }
        

        internal Matrix First { get => first; set => first = value; }
        internal Matrix Second { get => second; set => second = value; }
        internal Matrix Result { get => result; set => result = value; }

        public  int multiply(int[] column, int[] row, int value)
        {
            int res = 0;
            for (int j = 0; j < value; j++)
            {
                res += column[j] * row[j];
            }
            //Thread.Sleep(1);
            return res;
        }

        public  void multiply(Object value)
        {
            if (value is Point point)
                result.MatrixValues[point.Row, point.Column] = multiply(Second.Cols()[point.Column], First.Rows()[point.Row], First.SizeX);
            if (value is Range range)
            {
                for (int row = range.Begin; row <= range.End; row++)
                    for (int col = 0; col < First.SizeY; col++)
                        result.MatrixValues[row, col] = multiply(Second.Cols()[col], First.Rows()[row], First.SizeY);
            }
        }
    }
}
