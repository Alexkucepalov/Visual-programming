namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        GenericsDescSortedList<int> doublelistInt = new GenericsDescSortedList<int>();
        GenericsDescSortedList<string> doublelistStr = new GenericsDescSortedList<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (radioButton_INT.Checked)
            {
                

                int number;
                string value = textBox_add.Text;
                bool succes = int.TryParse(value, out number);
                if (succes)
                {
                    label_add_info.Text = "Ёлемент добавлен";
                    listBox1.Items.Clear();
                    doublelistInt.Add(number);
                    textBox_add.Clear();
                    textBox_add.Focus();
                    foreach (int i in doublelistInt)
                    {
                        listBox1.Items.Add(i);
                    }


                }
                else
                {
                    label_add_info.Text = "ќшибка добавлени€";
                }
            }
            else
            {
                string value = textBox_add.Text;
                label_add_info.Text = "Ёлемент добавлен";
                listBox1.Items.Clear();
                doublelistStr.Add(value);
                textBox_add.Clear();
                textBox_add.Focus();
                foreach (string i in doublelistStr)
                {
                    listBox1.Items.Add(i);
                }
            }
            
        }

        private void textBox_add_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_list_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_INT_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton_STR.Checked)
            {
                foreach (string i in doublelistStr)
                {
                    listBox1.Items.Add(i);
                }

            }
            if (radioButton_INT.Checked)
            {
                foreach (int i in doublelistInt)
                {
                    listBox1.Items.Add(i);
                }

            }
        }

        private void button_add_first_Click(object sender, EventArgs e)
        {
            if (radioButton_INT.Checked)
            {
                int number;
                string value = textBox_add_first.Text;
                bool succes = int.TryParse(value, out number);
                if (succes)
                {
                    label_add_info.Text = "Ёлемент добавлен";
                    listBox1.Items.Clear();
                    doublelistInt.AddFirst(number);
                    foreach (int i in doublelistInt)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                else
                {
                    label_add_info.Text = "ќшибка добавлени€";
                }
            }
            else
            {
                string value = textBox_add_first.Text;
                label_add_info.Text = "Ёлемент добавлен";
                listBox1.Items.Clear();
                doublelistStr.AddFirst(value);
                foreach (string i in doublelistStr)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button_add_last_Click(object sender, EventArgs e)
        {
            if (radioButton_INT.Checked)
            {
                int number;
                string value = textBox_add_last.Text;
                bool succes = int.TryParse(value, out number);
                if (succes)
                {
                    label_add_info.Text = "Ёлемент добавлен";
                    listBox1.Items.Clear();
                    doublelistInt.AddLast(number);
                    foreach (int i in doublelistInt)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                else
                {
                    label_add_info.Text = "ќшибка добавлени€";
                }
            }
            else
            {
                string value = textBox_add_last.Text;
                label_add_info.Text = "Ёлемент добавлен";
                listBox1.Items.Clear();
                doublelistStr.AddLast(value);
                foreach (string i in doublelistStr)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button_get_rand_Click(object sender, EventArgs e)
        {
            if (radioButton_INT.Checked)
            {
                textBox_rand.Text = doublelistInt.GetRand().ToString();
            }
            else
            {
                textBox_rand.Text = doublelistStr.GetRand().ToString();
            }
        }

        private void button_get_N_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(numericUpDown_get_N.Value);
            
            if (radioButton_INT.Checked)
            {
                if(N <= doublelistInt.Count)
                {
                    textBox_get_N.Text = doublelistInt.GetN(N).ToString();
                }
                else
                {
                    MessageBox.Show("ћожно выбрать до " + doublelistInt.Count.ToString() + " элемента");
                }
                
            }
            else
            {
                if (N < doublelistStr.Count)
                {
                    textBox_get_N.Text = doublelistStr.GetN(N).ToString();
                }
                else
                {
                    MessageBox.Show("ћожно выбрать до " + doublelistStr.Count.ToString() + " элемента");
                }
                
            }
        }

        private void button_get_max_Click(object sender, EventArgs e)
        {
            if (radioButton_INT.Checked)
            {
                textBox_get_max.Text = doublelistInt.GetMax().ToString();
            }
            else
            {
                textBox_get_max.Text = doublelistStr.GetMax().ToString();
            }
        }

        private void button_get_min_Click(object sender, EventArgs e)
        {
            if (radioButton_INT.Checked)
            {
                textBox_get_min.Text = doublelistInt.GetMin().ToString();
            }
            else
            {
                textBox_get_min.Text = doublelistStr.GetMin().ToString();
            }
        }

        private void button_get_count_Click(object sender, EventArgs e)
        {
            if (radioButton_INT.Checked)
            {
                textBox_get_count.Text = doublelistInt.Count.ToString();
            }
            else
            {
                textBox_get_count.Text = doublelistStr.Count.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}