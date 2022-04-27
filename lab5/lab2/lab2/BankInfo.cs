using System;
using System.Collections.Generic;


namespace lab2
{
   
    [Serializable]
    public class BankInfo: IClone
    {
        public List<BankAccount> Account { get; set; }
        public Owner Owner { get; set; }
        public BankInfo()
        {
            Owner = new Owner();
            Account = new List<BankAccount>();
        }

        public BankInfo(List<BankAccount> accounts, Owner owners)
        {
            this.Account = accounts;
            this.Owner = owners;
        }

        public IClone Clone()
        {
            var infok = new BankInfo();
            infok = (BankInfo)this.MemberwiseClone();   //создаёт неполную копию текущего объекта
            return infok;
            //return new BankInfo(Account, Owner);
        }   
    }
}
