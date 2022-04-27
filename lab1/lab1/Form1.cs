using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        float a;
        double b;
        int count;
        float memory = 0;
        bool z = true;

        public Form1()
        {
            InitializeComponent();
            Text = "Calculator";
            this.Size = new Size(380, 395);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void digit_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "button5" &&
                   !textBox1.Text.Contains(',')) textBox1.Text += (sender as Button).Text;
            else if ((sender as Button).Name == "button5") return;
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                if (textBox1.Text == "") { throw new Exception("Input number"); }
                textBox1.Clear();
                count = 1;
                textBox1.Text = "sin " + a.ToString();
            }
            catch
            {
                return;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                if (textBox1.Text == "") { throw new Exception("Input number"); }
                textBox1.Clear();
                count = 2;
                textBox1.Text = "cos " + a.ToString();
            }
            catch
            {
                return;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                if (textBox1.Text == "") { throw new Exception("Input number"); }
                textBox1.Clear();
                count = 3;
                textBox1.Text = "tan " + a.ToString();
            }
            catch
            {
                return;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                if (textBox1.Text == "") { throw new Exception("Input number"); }
                textBox1.Clear();
                count = 5;
                textBox1.Text = "∛" + a.ToString();
            }
            catch
            {
                return;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                if (textBox1.Text == "") { throw new Exception("Input number"); }
                textBox1.Clear();
                count = 4;
                label1.Text = a.ToString() + "^";
            }
            catch
            {
                return;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                if (textBox1.Text == "") { throw new Exception("Input number"); }
                textBox1.Clear();
                count = 6;
                textBox1.Text = "√" + a.ToString();
            }
            catch
            {
                return;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            memory = float.Parse(label1.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    label1.Text = "";
                    if (textBox1.Text == "") { throw new Exception("Сначала введите число"); }
                    b = Math.Round(Math.Sin(a * Math.PI / 180), 5);
                    label1.Text = b.ToString();
                    textBox1.Text = "";
                    break;
                case 2:
                    b = Math.Round(Math.Cos(a * Math.PI / 180), 5);
                    label1.Text = b.ToString();
                    textBox1.Text = "";
                    break;
                case 3:
                    b = Math.Round(Math.Tan(a * Math.PI / 180), 5);
                    label1.Text = b.ToString();
                    textBox1.Text = "";
                    break;
                case 4:
                    b = Math.Pow(a, float.Parse(textBox1.Text));
                    b = Math.Round(b, 5);
                    label1.Text = b.ToString();
                    textBox1.Text = "";
                    break;
                case 5:
                    b = (float)Math.Pow(a, (1.0 / 3.0));
                    label1.Text = b.ToString();
                    textBox1.Text = "";
                    break;
                case 6:
                    b = (float)Math.Sqrt(a);
                    label1.Text = b.ToString();
                    textBox1.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
