using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("bug.jpg");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
