using System;
using System.Windows.Forms;

namespace lab2
{
    public abstract class Builder
    {
        public BankAccount OwnerAndAccount { get; private set; }
        public void Accountconst() => OwnerAndAccount = new BankAccount();
        public abstract void CreateAccount();
        public abstract void CreateOwner();
    }

    class Director
    {
        public BankAccount Totality(Builder factory)
        {
            factory.Accountconst();
            factory.CreateAccount();
            factory.CreateOwner();
            return factory.OwnerAndAccount;
        }
        public static void OwnerPlusAccount()
        {
            Director director = new Director();

            Builder build = new ConcreteBuilder();
            BankAccount acc = director.Totality(build);
            MessageBox.Show($"Фамилия владельца: {acc.Owner.Surname}\n" +
                            $"Имя владельца: {acc.Owner.Name}\n" +
                            $"Отчество владельца: {acc.Owner.Patronymic}\n" +
                            $"Номер паспорта: {acc.Owner.PassportNum}\n" +
                            $"Номер аккаунта: {acc.Account_number}");
        }
    }
    public class ConcreteBuilder : Builder //ProductA1
    {
        public override void CreateAccount()
        {
            OwnerAndAccount.Account_number = 3254672;
            OwnerAndAccount.Balance = 1000;
            OwnerAndAccount.Deposit_type = "Чековый вклад";
            OwnerAndAccount.Opening_date = new DateTime(2015, 7, 20);
            OwnerAndAccount.Owner.PassportNum = "3176888";

        }

        public override void CreateOwner()
        {
            OwnerAndAccount.Owner = new Owner("Прокопович", "Надежда", "Ивановна", "834652");
        }

    }
}
