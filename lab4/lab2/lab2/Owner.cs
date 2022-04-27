using System;

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
    }
    
}