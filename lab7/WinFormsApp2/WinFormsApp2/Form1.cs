using System.Data;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Vector3D V1 = new Vector3D();
        Vector3D V2 = new Vector3D();
        Vector3D V3 = new Vector3D();
        Vector3D V4 = new Vector3D();
        Vector3D V5 = new Vector3D();
        Vector3D V6 = new Vector3D();
        double scalar, modul;

        List<Vector3D> vectors_list = new List<Vector3D>();
        public Form1()
        {
            InitializeComponent();

        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double chislo;
            string input_x1 = textBox2.Text;
            string input_y1 = textBox3.Text;
            string input_z1 = textBox4.Text;
            string input_x2 = textBox7.Text;
            string input_y2 = textBox6.Text;
            string input_z2 = textBox5.Text;
            string input_x3 = textBox22.Text;
            string input_y3 = textBox21.Text;
            string input_z3 = textBox20.Text;
            string input_x4 = textBox25.Text;
            string input_y4 = textBox24.Text;
            string input_z4 = textBox23.Text;
            string input_x5 = textBox28.Text;
            string input_y5 = textBox27.Text;
            string input_z5 = textBox26.Text;
            string input_scalar = textBox9.Text;
            try
            {
                chislo = Convert.ToDouble(input_x1);
                V1.X = chislo;
                chislo = Convert.ToDouble(input_y1);
                V1.Y = chislo;
                chislo = Convert.ToDouble(input_z1);
                V1.Z = chislo;
                chislo = Convert.ToDouble(input_x2);
                V2.X = chislo;
                chislo = Convert.ToDouble(input_y2);
                V2.Y = chislo;
                chislo = Convert.ToDouble(input_z2);
                V2.Z = chislo;
                chislo = Convert.ToDouble(input_x3);
                V4.X = chislo;
                chislo = Convert.ToDouble(input_y3);
                V4.Y = chislo;
                chislo = Convert.ToDouble(input_z3);
                V4.Z = chislo;
                chislo = Convert.ToDouble(input_x4);
                V5.X = chislo;
                chislo = Convert.ToDouble(input_y4);
                V5.Y = chislo;
                chislo = Convert.ToDouble(input_z4);
                V5.Z = chislo;
                chislo = Convert.ToDouble(input_x5);
                V6.X = chislo;
                chislo = Convert.ToDouble(input_y5);
                V6.Y = chislo;
                chislo = Convert.ToDouble(input_z5);
                V6.Z = chislo;
                scalar = Convert.ToDouble(input_scalar);


                calc(sender, e);

                MessageBox.Show("Расчеты были выполнены успешно", "Успешно!");
            }
            catch
            {
                MessageBox.Show("Введено не число!", "Ошибка!");
            }

        }

        private void calc(object sender, EventArgs e)
        {
            V3 = V1 + V2;
            textBox8_TextChanged(sender, e);
            V3 = V1 - V2;
            textBox10_TextChanged(sender, e);
            V3 = V1 * scalar;
            textBox12_TextChanged(sender, e);
            V3 = V2 * scalar;
            textBox11_TextChanged(sender, e);

            modul = Math.Round(Vector3D.modul(V1), 2);
            textBox14_TextChanged(sender, e);
            modul = Math.Round(Vector3D.modul(V2), 2);
            textBox13_TextChanged(sender, e);

            V3 = Vector3D.proectionDecart(V1);
            textBox16_TextChanged(sender, e);
            V3 = Vector3D.proectionDecart(V2);
            textBox15_TextChanged(sender, e);

            V3 = Vector3D.proectionCilindr(V1);
            textBox17_TextChanged(sender, e);
            V3 = Vector3D.proectionCilindr(V2);
            textBox1_TextChanged(sender, e);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string x = Convert.ToString(V3.X);
            string y = Convert.ToString(V3.Y);
            string z = Convert.ToString(V3.Z);
            textBox8.Text = $"({x} ; {y} ; {z})";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string x = Convert.ToString(V3.X);
            string y = Convert.ToString(V3.Y);
            string z = Convert.ToString(V3.Z);
            textBox10.Text = $"({x} ; {y} ; {z})";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            string x = Convert.ToString(V3.X);
            string y = Convert.ToString(V3.Y);
            string z = Convert.ToString(V3.Z);
            textBox12.Text = $"({x} ; {y} ; {z})";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string x = Convert.ToString(V3.X);
            string y = Convert.ToString(V3.Y);
            string z = Convert.ToString(V3.Z);
            textBox11.Text = $"({x} ; {y} ; {z})";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            string mod = Convert.ToString(modul);
            textBox13.Text = $"|{mod}|";
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            string x = Convert.ToString(V3.X);
            string y = Convert.ToString(V3.Y);
            string z = Convert.ToString(V3.Z);
            textBox16.Text = $"Ox: {x}; Oy: {y}; Oz: {z}";
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            string x = Convert.ToString(V3.X);
            string y = Convert.ToString(V3.Y);
            string z = Convert.ToString(V3.Z);
            textBox15.Text = $"Ox: {x}; Oy: {y}; Oz: {z}";
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            string x = Convert.ToString(V3.X);
            string y = Convert.ToString(V3.Y);
            string z = Convert.ToString(V3.Z);
            textBox17.Text = $"r: {x}; phi: {y}; z: {z}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = Convert.ToString(V3.X);
            string y = Convert.ToString(V3.Y);
            string z = Convert.ToString(V3.Z);
            textBox1.Text = $"r: {x}; phi: {y}; z: {z}";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            string mod = Convert.ToString(modul);
            textBox14.Text = $"|{mod}|";
        }

        private void ListView_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double chislo;
            string input_x1 = textBox2.Text;
            string input_y1 = textBox3.Text;
            string input_z1 = textBox4.Text;
            string input_x2 = textBox7.Text;
            string input_y2 = textBox6.Text;
            string input_z2 = textBox5.Text;
            string input_x3 = textBox22.Text;
            string input_y3 = textBox21.Text;
            string input_z3 = textBox20.Text;
            string input_x4 = textBox25.Text;
            string input_y4 = textBox24.Text;
            string input_z4 = textBox23.Text;
            string input_x5 = textBox28.Text;
            string input_y5 = textBox27.Text;
            string input_z5 = textBox26.Text;
            try
            {
                chislo = Convert.ToDouble(input_x1);
                V1.X = chislo;
                chislo = Convert.ToDouble(input_y1);
                V1.Y = chislo;
                chislo = Convert.ToDouble(input_z1);
                V1.Z = chislo;
                chislo = Convert.ToDouble(input_x2);
                V2.X = chislo;
                chislo = Convert.ToDouble(input_y2);
                V2.Y = chislo;
                chislo = Convert.ToDouble(input_z2);
                V2.Z = chislo;
                chislo = Convert.ToDouble(input_x3);
                V4.X = chislo;
                chislo = Convert.ToDouble(input_y3);
                V4.Y = chislo;
                chislo = Convert.ToDouble(input_z3);
                chislo = Convert.ToDouble(input_x4);
                V5.X = chislo;
                chislo = Convert.ToDouble(input_y4);
                V5.Y = chislo;
                chislo = Convert.ToDouble(input_z4);
                V5.Z = chislo;
                V4.Z = chislo;

                MessageBox.Show("Векторы добавлены!", "Успешно!");
            }
            catch
            {
                MessageBox.Show("Введено не число!\nИЛИ\nНе все векторы", "Ошибка!");
            }
        }

        private void buttonLINQ_Click(object sender, EventArgs e)
        {
            ListView.Clear();
            if (vectors_list.Count == 0)
            {
                vectors_list.Add(V1);
                vectors_list.Add(V2);
                vectors_list.Add(V4);
                vectors_list.Add(V5);
                vectors_list.Add(V6);
            }

            foreach (Vector3D vect in vectors_list)
            {
                ListView.Text += $"[{vect.X};" + $"{vect.Y};" + $"{vect.Z}]" + "  ";
            }

            LINQ_filter();
            LINQ_group();
        }

        /*
        private void LINQ_filter()
        {
            textBox_LINQ1.Clear();
           // comboBox1.Items.Add("Все координаты вектора больше 0");
            //comboBox1.Items.Add("Все координаты вектора меньше 0");
            
            var query =
                from vect in vectors_list
                where vect.X > 0 && vect.Y > 0 && vect.Z > 0
                select vect;
            
            foreach (Vector3D vect in query)
            {
                textBox_LINQ1.Text += $"[{vect.X};" + $"{vect.Y};" + $"{vect.Z}]" + "\t";
            }
        textBox29
        }*/
        private void LINQ_filter()
        {

        }


        private void ascending(object sender, EventArgs e)
        {
            textBox_ascending.Clear();
            dynamic query =
                from vect in vectors_list
                orderby vect.X
                select vect;

            foreach (Vector3D vect in query)
            {
                textBox_ascending.Text += $"[{vect.X};" + $"{vect.Y};" + $"{vect.Z}]" + "  ";
            }
        }

        private void descending_order(object sender, EventArgs e)
        {
            textBox_descending.Clear();
            dynamic query =
                from vect in vectors_list
                orderby vect.X descending
                select vect;

            foreach (Vector3D vect in query)
            {
                textBox_descending.Text += $"[{vect.X};" + $"{vect.Y};" + $"{vect.Z}]" + "  ";
            }
        }

        private void phi(object sender, EventArgs e)
        {
            textBox29.Clear();
            var query =
                from vect in vectors_list
                where vect.phi > 1
                select vect;

            foreach (Vector3D vect in query)
            {
                textBox29.Text += (Math.Round(vect.phi, 2)) + "  ";
            }
        }

        private void LINQ_group()
        {
            textBox_LINQ3.Clear();

            var query =
                from vect in vectors_list
                group vect by vect.X;

            
            foreach(var vectGroup in query)
            {
                textBox_LINQ3.Text += $"<{vectGroup.Key}>  ";
                foreach (Vector3D vect in vectGroup)
                {
                    textBox_LINQ3.Text += $"[{vect.X};" + $"{vect.Y};" + $"{vect.Z}]" + "  ";
                }
            }

        }
    }
}