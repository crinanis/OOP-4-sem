using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;

///ВАЛИДАЦИЯ

namespace lab2
{
    public partial class Form1 : Form
    {
        public BankInfo banking;

        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            banking = new BankInfo();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        

        private void button1_Click(object sender, EventArgs e)  //ДОБАВИТЬ
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Введите номер счёта!");
                return;
            }
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Выберите тип вклада!");
                return;
            }
            if (dateTimePicker1.Text.Equals(""))
            {
                MessageBox.Show("Укажите дату открытия счёта!");
                return;
            }
            if (textBox2.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals("")
                || textBox6.Text.Equals("") || dateTimePicker2.Text.Equals(""))
            {
                MessageBox.Show("Все поля информации о владельце должны быть заполнены!");
                return;
            }

            BankAccount acc = new BankAccount
            {
                Account_number = Int32.Parse(textBox3.Text),
                Deposit_type = comboBox1.Text,
                Opening_date = dateTimePicker1.Value,
                Balance = trackBar1.Value,
                Owner = new Owner
                {
                    Surname = textBox4.Text,
                    Name = textBox5.Text,
                    Patronymic = textBox6.Text,
                    PassportNum = textBox2.Text,
                }
            };
            banking.Account.Add(acc);

            acc.Result = "Владелец: " + acc.Owner.Surname + ", Баланс: "  + acc.Balance + "рублей, " + "Тип депозита: " + acc.Deposit_type + ", " + "Номер аккаунта: " + acc.Account_number;
            if (checkBox1.Checked) acc.Result += " + смс-оповещение";
            if (checkBox2.Checked) acc.Result += " + интернет-банкинг";
            if (checkBox3.Checked) acc.Result += " + еженедельная выписка по счёту";
            listBox1.Items.Add(acc.Result);
            var results = new List<ValidationResult>();
            var context = new ValidationContext(acc);
            if (Validator.TryValidateObject(acc, context, results, true))
                acc.Result += ", прошло валидацию";
            else
                acc.Result += ", не прошло валидацию";
        }

        private void button2_Click(object sender, EventArgs e)      //СОХРАНИТЬ
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BankInfo));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, banking);
            }
        }

        private void button3_Click(object sender, EventArgs e)      //ОТКРЫТЬ
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BankInfo));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.Open))
            {
                banking = serializer.Deserialize(stream) as BankInfo;
            }
            foreach (BankAccount bb in banking.Account)
                listBox1.Items.Add(bb.Result);
        }

        private void label2_Click(object sender, EventArgs e) //дата открытия
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //тип вклада
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)   //номер паспорта
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)   //баланс
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)   //дата открытия счёта
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   //смс-оповещение
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)   //интернет-банкинг
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)   //выписка
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)  //окно вывода
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)   //номер счёта
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)   //фамилия
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)   //имя
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)   //отчество
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e) //номер счёта
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e) //тип вклада
        {

        }

        private void label13_Click(object sender, EventArgs e) //доп. опции
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)   //дата рождения
        {

        }

        private void label15_Click(object sender, EventArgs e) //информация о счёте
        {

        }

        private void label4_Click(object sender, EventArgs e) //Баланс
        {

        }

        private void label14_Click(object sender, EventArgs e) //инфа о владельце
        {

        }

        private void label9_Click(object sender, EventArgs e) //фамилия
        {

        }

        private void label10_Click(object sender, EventArgs e) //имя
        {

        }

        private void label11_Click(object sender, EventArgs e) 
        {

        }

        private void фиоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поТипуВкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(BankInfo));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.Open))
                banking = ser.Deserialize(stream) as BankInfo;

            IEnumerable<BankAccount> ordered = banking.Account.OrderBy(p => p.Deposit_type);
            foreach (BankAccount bank in ordered)
                listBox1.Items.Add(bank.Result);
        }

        private void поДатеОткрытияВкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(BankInfo));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.Open))
                banking = ser.Deserialize(stream) as BankInfo;

            IEnumerable<BankAccount> ordered = banking.Account.OrderBy(p => p.Opening_date);
            foreach (BankAccount bank in ordered)
                listBox1.Items.Add(bank.Result);
        }

        private void поискToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            button3_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            button2_Click(null, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик - Буданова Ксения Андреевна");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
       
        }
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog(this);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
