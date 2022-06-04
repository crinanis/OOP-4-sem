using lab12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab12
{
    public partial class AddWorkerWindow : Window
    {
        public AddWorkerWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UnitOfWork unit = new UnitOfWork();

            Author w = new Author();
            w.id = 0;
            w.name = TextBox_name.Text;
            w.bookID = Convert.ToInt32(TextBox_planeId.Text);

            unit.Authors.Create(w);
            unit.Save();
            this.Close();
        }
    }
}
