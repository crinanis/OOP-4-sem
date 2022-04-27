using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   
    [Serializable]
    public class BankInfo
    {
        public List<BankAccount> Account { get; set; }
        public Owner Owner { get; set; }
        public BankInfo()
        {
            Owner = new Owner();
            Account = new List<BankAccount>();
        }
    }
}
