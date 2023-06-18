using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Potentiometer : UserControl
    {
        private Graphics g;
        private float radius = 100f;
        private float rRadius = 120f;
        private float angle = 0f;
        private float k = 0.05f;

        private PointF oldLocation = new PointF();
        Pen bPen = new Pen(Color.Black, 2f);

        // Хранит в себе список делегатов выполняемых при вращение
        public event EventHandler ChangeValuePotentiometer;
        public float Value
        {
            get
            {
                return angle * (180 / (float)Math.PI);
            }
        }

        public Potentiometer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.DrawEllipse(bPen, Width / 2 - radius, Height / 2 - radius, radius * 2, radius * 2); // круг

            double a = angle - Math.PI / 2; // метка

            g.DrawLine(bPen, (float)(radius * Math.Cos(a)) + Width / 2,
            (float)(radius * Math.Sin(a)) + Height / 2,
            (float)((radius - 5) * Math.Cos(a)) + Width / 2,
            (float)((radius - 5) * Math.Sin(a)) + Height / 2);

            for (float riskAngle = 0; riskAngle <= 330f; riskAngle += 330f / 11.0f) // риски
            {
                float risckA = riskAngle * ((float)Math.PI / 180f) - (float)Math.PI / 2;

                g.DrawLine(bPen, (float)(rRadius * Math.Cos(risckA)) + Width / 2,
                (float)(rRadius * Math.Sin(risckA)) + Height / 2,
                (float)((rRadius - 5) * Math.Cos(risckA)) + Width / 2,
                (float)((rRadius - 5) * Math.Sin(risckA)) + Height / 2);
            }
        }

        private void Potentiometer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                angle += (e.Location.X < oldLocation.X) ? -k : k;

                // Корректировка значения угла от 0 до 300 градусов
                if (angle <= 0f) angle = 0f;
                else if (angle >= (330f * (Math.PI / 180f))) angle = 330f * ((float)Math.PI / 180f);

                oldLocation = e.Location;
                this.OnChangeValuePotentiometer(EventArgs.Empty);
                Invalidate();
            }
        }

        // Метод выполняющий делегаты, подписанных на событие ChangeValuePotentiometer
        private void OnChangeValuePotentiometer(EventArgs e)
        {
            ChangeValuePotentiometer?.Invoke(this, e);
        }
    }
}
