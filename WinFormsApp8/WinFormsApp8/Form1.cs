using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        static XElement rootTag = XElement.Load("https://lenta.ru/rss/articles/"); //«агрузка сайта lenta.ru
        static XElement? channel = rootTag.Element("channel"); // ? - допускает значение null
        List<XElement> channelNodes = channel.Elements("item").ToList();
        public Form1()
        {
            InitializeComponent();

            List<XElement> titles = channelNodes.Elements("title").ToList();
            
            var Titles =
                from el in channelNodes
                where el.Name == "title"
                select el;

            int number = 1;
            foreach (XElement el in titles)
            {
                string insert = Convert.ToString(number) + ". " + el.Value; // добавл€ем номер статьи и заголовок в наш список
                listBox1.Items.Add(insert);
                number++;
            }
            label1.Text = "¬сего найденно статей: " + Convert.ToString(listBox1.Items.Count); 


            IEnumerable<XElement> head = 
                from el in channel.Elements()
                where 
                    el.Name == "title" || 
                    el.Name == "link"  ||
                    el.Name == "description" ||
                    el.Name == "pubDate" 
                select el;

            foreach (XElement el in head)
            {
                richTextBox1.Text += $"{(string)el}" + "\n";
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            XElement? image = channel.Element("image"); // получаем лого
            var imageURL =
                from el in image.Elements()
                where el.Name == "url"
                select el;

            foreach (XElement url in imageURL)
            {
                pictureBox1.Load((string)url);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // открытие статьи по щелчку мыши
        {
            int index = listBox1.SelectedIndex;

            IEnumerable<XElement> item =
               from el in channelNodes[index].Elements()
               select el;

            richTextBox1.Clear();

            foreach (XElement el in item)
            {
                if(el.Name == "description")
                {
                    richTextBox1.Text += "\r\n" + $"{(string)el}" + "\r\n\r\n";
                }
                else
                {
                    richTextBox1.Text += $"{(string)el}" + "\r\n";
                }
                
            }

            richTextBox1.Text = richTextBox1.Text.Replace("<br>", "\r\n");
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}