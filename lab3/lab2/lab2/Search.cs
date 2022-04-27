using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;

namespace lab2
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r1 = new Regex(textBox1.Text);
            BankInfo bank = null;

            XmlSerializer ser = new XmlSerializer(typeof(BankInfo));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.Open))
            {
                bank = ser.Deserialize(stream) as BankInfo;
            }
            listBox1.Items.Clear();
            List<BankAccount> searchResult = new List<BankAccount>();
            foreach (BankAccount acc in bank.Account)
            {
                if (r1.IsMatch(acc.Owner.PassportNum))
                {                    
                    searchResult.Add(acc);
                }
            }
            IEnumerable<BankAccount> ordered = null;
            if (domainUpDown1.Text == "По номеру паспорта")
                ordered = searchResult.OrderBy(p => p.Owner.PassportNum);
            else
                ordered = searchResult.OrderBy(p => p.Owner.Patronymic);
            foreach (BankAccount item in ordered)
                listBox1.Items.Add(item.Result);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
