using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    [Serializable]
    public class BankAccount
    {
        public DateTime Opening_date { get; set; }
        public string Deposit_type { get; set; }
        public int Balance { get; set; }
        public int Account_number { get; set; }
        public string Result { get; set; }
        public Owner Owner { get; set; }
    }
}
