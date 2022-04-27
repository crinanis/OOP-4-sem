using System;

namespace lab2
{
    public abstract class AbstractFactory
    {
        public abstract Owner CreateOwner();            //абстрактные продукты
    }

    public class FirFactory : AbstractFactory
    {
        public override Owner CreateOwner()
        {
            return new FirOwner();
        }
    }
    public class SecFactory : AbstractFactory
    {
        public override Owner CreateOwner()
        {
            return new SecOwner();
        }
    }
    public class ThiFactory : AbstractFactory
    {
        public override Owner CreateOwner()
        {
            return new ThiOwner();
        }
    }
    public class FouFactory : AbstractFactory
    {
        public override Owner CreateOwner()
        {
            return new FouOwner();
        }
    }
    public class FifFactory : AbstractFactory
    {
        public override Owner CreateOwner()
        {
            return new FifOwner();
        }
    }
    public class SixFactory : AbstractFactory
    {
        public override Owner CreateOwner()
        {
            return new SizOwner();
        }
    }
    [Serializable]
    public class FirOwner : Owner
    {
        public FirOwner()
        {
            Surname = "Шпак";
        }
    }
    [Serializable]
    public class SecOwner : Owner
    {
        public SecOwner()
        {
            Surname = "Соколов";
        }
    }
    [Serializable]
    public class ThiOwner : Owner
    {
        public ThiOwner()
        {
            Surname = "Ковалёв";
        }
    }
    [Serializable]
    public class FouOwner : Owner
    {
        public FouOwner()
        {
            Surname = "Фомин";
        }
    }
    [Serializable]
    public class FifOwner : Owner
    {
        public FifOwner()
        {
            Surname = "Воронин";
        }
    }
    [Serializable]
    public class SizOwner : Owner
    {
        public SizOwner()
        {
            Surname = "Пономарев";
        }
    }
}
