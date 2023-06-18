using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Lab9
{
    class Matrix
    {
        private int sizeX;
        private int sizeY;
        private int[,] matrixValues;
        List<int[]> rows, cols;
        
        public int SizeX { get => sizeX; set => sizeX = value; }
        public int SizeY { get => sizeY; set => sizeY = value; }
        public int[,] MatrixValues { get => matrixValues; set => matrixValues = value; }
        public List<int[]> Rows() => rows;
        public List<int[]> Cols() => cols;


        public Matrix(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            matrixValues = new int[sizeX, sizeY];
            Random rand = new Random();
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    matrixValues[i, j] = rand.Next(10);
                }
            }

            rows = new List<int[]>(this.sizeX);
            for (int i = 0; i < this.sizeX; i++)
            {
                int[] arr = new int[sizeX];
                for (int j = 0; j < this.sizeY; j++)
                {
                    arr[j] = this.matrixValues[i, j];
                }
                rows.Add(arr);
            }


            cols = new List<int[]>(this.sizeX);
            for (int i = 0; i < this.sizeX; i++)
            {
                int[] arr = new int[sizeY];
                for (int j = 0; j < this.sizeY; j++)
                {
                    arr[j] = this.matrixValues[j, i];
                }
                cols.Add(arr);
            }
        }
    }
}
