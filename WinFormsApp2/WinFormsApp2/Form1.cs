namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Vector3D V1 = new Vector3D();
        Vector3D V2 = new Vector3D();
        Vector3D V3 = new Vector3D();
        double scalar, modul;
        public Form1()
        {
            InitializeComponent();
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
            string input_scalar = textBox9.Text;
            try
            {
                chislo = Convert.ToDouble(input_x1);  // Преобразует заданное значение в число с плавающей запятой двойной точности.
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
                scalar = Convert.ToDouble(input_scalar);

                calc(sender, e);
                
                MessageBox.Show("Программа выполнила необходимые расчеты", "Поздравляем!");
            }
            catch
            {
                MessageBox.Show("Введите число!", "Ошибка!");
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
    } 
}