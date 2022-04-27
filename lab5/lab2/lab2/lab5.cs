using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class lab5 : Form
    {
        public lab5()
        {
            InitializeComponent();
        }

        private void lab5_Load(object sender, EventArgs e)
        {
            Invoker invoker = new Invoker();
            SimpleCommand simple = new SimpleCommand("Say Hi!");
            Owner receiver = new Owner();
            ComplexCommand complex = new ComplexCommand(receiver, "Send email", "Save report");
            invoker.SetOnStart(simple);
            invoker.SetOnFinish(complex);
            invoker.DoSomethingImportant();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner adapte = new Owner("Волочук", "Евгения", "Витальевна", "327642");
            Target target = new Adapter(adapte);
            MessageBox.Show(target.Say());            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
