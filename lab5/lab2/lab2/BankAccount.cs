using System;

namespace lab2
{
    [Serializable]
    public class BankAccount:IClone
    {
        public DateTime Opening_date;
        public string Deposit_type;
        public int Balance;
        public int Account_number;
        public string Result;
        public Owner Owner;

        public BankAccount()
        {
            Owner = new Owner();
        }

        public BankAccount(DateTime open, string deposit, int balance, int account, string result, Owner owner)
        {
            Opening_date = open;
            Deposit_type = deposit;
            Balance = balance;
            Account_number = account;
            Result = result;
            Owner = owner;
        }

        public IClone Clone()
        {
            var acc = new BankAccount();
            acc = (BankAccount)this.MemberwiseClone();
            return acc;
        }
    }
}
