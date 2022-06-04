using lab12.Context;
using lab12.Models;
using System.Data.Entity;
using System.Linq;
using System.Windows;


namespace lab12
{
    public partial class MainWindow : Window
    {
        MyDb mdb;
        public MainWindow()
        {
            InitializeComponent();

            mdb = new MyDb();

            //Author author1 = new Author { id = 1, name = "Author1", bookID = 6 };
            //Author author2 = new Author { id = 2, name = "Author2", bookID = 7 };
            //Author author3 = new Author { id = 3, name = "Author3", bookID = 6 };
            //mdb.Author.Add(author1);
            //mdb.Author.Add(author2);
            //mdb.Author.Add(author3);
            //mdb.SaveChanges();

            authorGrid.ItemsSource = mdb.Author.Local.ToBindingList();

            this.Closing += MainWindow_Closing;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mdb.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            mdb.SaveChanges();
            mdb.Author.Load();
            authorGrid.ItemsSource = mdb.Author.Local.ToBindingList();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (authorGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < authorGrid.SelectedItems.Count; i++)
                {
                    Author worker = authorGrid.SelectedItems[i] as Author;
                    if (worker != null)
                    {
                        mdb.Author.Remove(worker);
                    }
                }
            }
            mdb.SaveChanges();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddWorkerWindow win = new AddWorkerWindow();
            win.ShowDialog();
        }

        private void queryButton_Click(object sender, RoutedEventArgs e)
        {
            Author.GetNameById(11);
        }

        private void updateItemButton_Click(object sender, RoutedEventArgs e)
        {
            if(authorGrid.SelectedItems.Count > 0)
            {
                var author = authorGrid.SelectedItem as Author;
                var change = mdb.Author.Where(c => c.name == author.name).FirstOrDefault();
                change.name = TextBox_Name.Text;
                mdb.SaveChanges();
            }
            mdb.Author.Load();
            authorGrid.ItemsSource = mdb.Author.ToList();
        }
    }
}
