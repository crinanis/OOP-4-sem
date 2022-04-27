using System;
using System.Windows.Forms;

namespace lab2
{
    [Serializable]
    public class Owner
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public string PassportNum;

        public Owner() { }

        public Owner(string surname, string name, string patronymic, string passport)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PassportNum = passport;
        }

        public string Say()
        {
            return $"Фамилия владельца {Surname}";
        }

        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Also working on ({b}.)");
        }
    }
    
}