using System;
using System.Drawing;
using System.Windows.Forms;

namespace VP_5
{
    public partial class Form1 : Form
    {
        // делегат для определения найденной окружности
        private delegate void CircleEventHandler(object sender, CircleEventArgs ce);
        // событие поиска окружности
        private event CircleEventHandler foundCircle;

        public Form1()
        {
            InitializeComponent();
            SetMapSize();
            // подписка на событие
            foundCircle += circleEventHandler;
        }

        // событие на которое была подписка выше
        private void circleEventHandler(object sender, CircleEventArgs ce)
        {
            drawMode = false;
            pictureBox.Image = map;
            // создание модального окна с найденной окружностью и её длиной посчитанной
            MessageBox.Show($"Длина круга = {Math.Round(ce.CirculeLength, 0)} точек");
        }

        // класс для нахождения длины окружности
        private class CircleEventArgs
        {
            private double circuleLength;
            public double CirculeLength
            {
                get { return circuleLength; }
                set { circuleLength = value; }
            }
        }

        // класс с точками
        private class PointArray
        {
            private int count;
            private Point[] points;
            private Point firstPoint;

            public PointArray()
            {
                count = 0;
                points = new Point[2];
            }

            public PointArray(int size)
            {
                count = 0;

                if (size<=0)
                    size = 2;

                points = new Point[size];
            }

            // задание точек
            public Point Point1{ get { return points[0]; } }

            public Point Point2{ get { return points[1]; } }

            public Point Point3{ get { return points[2]; } }

            public Point FirstPoint{ get { return firstPoint;} }

            public Point LastPoint
            {
                get
                {
                    if (count == 1)
                        return points[0];
                    else if (count == 2){
                        return points[1];
                    }
                    else if (count == 3){
                        return points[2];
                    }

                    Point noInitPoint = new Point();

                    return noInitPoint;
                }
            }

            // подсчёт количества точек

            public int Count
            {
                get { return count; }
                set { count = value; }
            }

            // задание точек
            public void SetPoint(int x, int y)
            {
                if (count < maxCountPoints)
                {
                    points[count] = new Point(x, y);
                    if (count == 0)
                        firstPoint = points[count];
                    count++;
                }
                else
                {
                    for (int i = 0; i < count - 1; i++)
                    {
                        points[i] = points[i + 1];
                    }
                    points[count - 1] = new Point(x, y);
                }
            }

            public void ResetPoints(){ count = 0; }

            public int GetCountPoints(){ return count; }

            public Point[] GetPoints(){ return points;}
            
            // считывание угла по точкам
            public double Angle
            {
                get
                {
                    return Math.Acos(((Point3.X - Point2.X) * (Point1.X - Point2.X) + 
                        (Point3.Y - Point2.Y) * (Point1.Y - Point2.Y)) / 
                        (Math.Sqrt((Point3.X - Point2.X) * (Point3.X - Point2.X) + (Point3.Y - Point2.Y) * (Point3.Y - Point2.Y)) * 
                        Math.Sqrt((Point1.X - Point2.X) * (Point1.X - Point2.X) + (Point1.Y - Point2.Y) * (Point1.Y - Point2.Y))));
                }
            }

            // понять по найденному углу окружность это или нет
            public bool CircleCondition()
            {
                if ((Angle > Math.PI/2) && (Angle < Math.PI))
                    return true;

                return false;
            }
        }

        private static int maxCountPoints = 3;
        // шаг в массиве точек (чем он меньше - тем движения более корявенькие
        // и программа может не считать окружность)
        private int step = 11;
        private PointArray pointArray = new PointArray(maxCountPoints);

        private Bitmap map = new Bitmap(100, 100);
        private Graphics graphics;
        private Pen pen = new Pen(Color.MediumPurple, 3f);

        private bool drawMode = true;
        private int countCirculePoints = 0;
        private int minCountCirculePoints = 5;

        public void ClearPoints()
        {
            graphics.Clear(pictureBox.BackColor);
            pictureBox.Image = map;
            pointArray.Count = 0;
        }

        private void SetMapSize()
        {
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rect.Width, rect.Height);
            graphics = Graphics.FromImage(map);
            MessageBox.Show("Стартуем");
        }
     

        // отслеживание движений мыши в пикчербоксе
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            CircleEventArgs ce = new CircleEventArgs();
            double CirculeLength = 0;

            if (!drawMode)
                return;
            else if (pointArray.Count == 0)
            {
                pointArray.SetPoint(e.X, e.Y);
                countCirculePoints++;
                graphics.DrawLine(pen, pointArray.Point1, pointArray.Point1);
                return;
            }
            else if (pointArray.Count == 1)
            {
                if ((Math.Abs(e.X - pointArray.LastPoint.X) < step) || (Math.Abs(e.Y - pointArray.LastPoint.Y) < step))
                    return;
                pointArray.SetPoint(e.X, e.Y);
                countCirculePoints++;
                graphics.DrawLine(pen, pointArray.Point1, pointArray.Point2);
                CirculeLength += Math.Sqrt((pointArray.Point2.X-pointArray.Point1.X) * (pointArray.Point2.X - pointArray.Point1.X) + 
                    (pointArray.Point2.Y - pointArray.Point1.Y) * (pointArray.Point2.Y - pointArray.Point1.Y));
                return;
            }

            if ((Math.Abs(e.X - pointArray.LastPoint.X) < step) || (Math.Abs(e.Y - pointArray.LastPoint.Y) < step))
                return;

            pointArray.SetPoint(e.X, e.Y);
            countCirculePoints++;
            graphics.DrawLine(pen, pointArray.Point2, pointArray.Point3);

            CirculeLength += Math.Sqrt((pointArray.Point3.X - pointArray.Point2.X) * (pointArray.Point3.X - pointArray.Point2.X) +
                    (pointArray.Point3.Y - pointArray.Point2.Y) * (pointArray.Point3.Y - pointArray.Point2.Y));
            ce.CirculeLength = CirculeLength;
            
            if (!pointArray.CircleCondition())
            {
                ClearPoints();
                countCirculePoints = 0;
            }

            if ((countCirculePoints >= minCountCirculePoints) && 
                (Math.Abs(pointArray.Point3.X - pointArray.FirstPoint.X) < minCountCirculePoints*step) && 
                (Math.Abs(pointArray.Point3.Y - pointArray.FirstPoint.Y) < minCountCirculePoints*step))
            {
                try
                {
                    if (foundCircle == null)
                    {
                        throw new Exception("Нет подписчиков на событие");
                    }
                    else
                        foundCircle(this, ce);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Внимание!");
                    return;
                }

            }
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            ClearPoints();
            countCirculePoints = 0;
            drawMode = true;
            Action line = () => Console.WriteLine(); 

            Form2 dlg = new Form2();
            dlg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button_clear_points_Click(object sender, EventArgs e)
        {
        }
    }
}
