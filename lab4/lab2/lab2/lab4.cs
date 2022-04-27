using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class lab4 : Form
    {
        public lab4()
        {
            InitializeComponent();
        }

        private void lab4_Load(object sender, EventArgs e)
        {

        }

        public Singleton font { get; set; }


        private void button2_Click(object sender, EventArgs e)
        {
            font = Singleton.GetInstance(this.Font.ToString());
            MessageBox.Show(font.settings);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Director.OwnerPlusAccount();
        }
    }
}
