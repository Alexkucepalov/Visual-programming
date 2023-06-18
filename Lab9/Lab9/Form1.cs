using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab9
{
    public partial class lab9 : Form
    {
        
        public lab9()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            int countThread = Convert.ToInt32(countThreadTB.Text); // преобразование в int 
            int sizeX = Math.Max(Convert.ToInt32(m1RowsTB.Text), Convert.ToInt32(m2ColTB.Text)); // возвращает большее из двух указанных
            int sizeY = Math.Max(Convert.ToInt32(m1ColTB.Text), Convert.ToInt32(m2RowsTB.Text));
            Matrix result = new Matrix(sizeX, sizeY);

            Matrix first = new Matrix(sizeX, sizeY);
            Matrix second = new Matrix(sizeX, sizeY);
            

            
            int RangeSize = (int)Math.Ceiling((double)sizeX + sizeY / (2 * (double)countThread)); // Размер диапазона для одного потока

            List<Thread> Threads = new List<Thread>(); // Список потоков
            MultiThreadMatrixMultiplication mult = new MultiThreadMatrixMultiplication(first, second, result);

            for (int row = 0; row < sizeX; row += RangeSize)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(mult.multiply));
                thread.Start(new Range() { Begin = row, End = (row + RangeSize) > sizeX ? (sizeX - 1) : (row + RangeSize - 1) });
                Threads.Add(thread);
            }

            foreach (Thread thread in Threads) { thread.Join(); } // объединение 


            result = mult.Result;


            dataGridView1.RowCount = result.SizeX;
            dataGridView1.ColumnCount = result.SizeY;
            for (int i = 0; i < result.SizeX; i++)
            {
                for (int j = 0; j < result.SizeY; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = result.MatrixValues[i, j];
                }
            }
        }
    }
}
