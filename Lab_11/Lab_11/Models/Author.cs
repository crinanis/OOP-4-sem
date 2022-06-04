using lab12.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab12.Models
{
    public class Author
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int bookID { get; set; }

        public static async Task addAuthor(Author w)
        {
            MyDb wc = new MyDb();
            try
            {
                wc.Author.Add(w);
                await wc.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetNameById(int id)
        {
            MyDb wc = new MyDb();
            var result = wc.Author.Where(p => p.id == id);
            StringBuilder str = new StringBuilder();
            foreach( Author i in result)
            {
                str.Append(i.name + "\r\n");
            }
            MessageBox.Show(str.ToString());
        }
    }

}
