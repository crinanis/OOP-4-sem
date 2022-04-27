namespace lab2
{
    public sealed class Singleton
    {
        private static Singleton instance;
        public string settings;
        private Singleton(string settings)
        {
            this.settings = settings;
        }
        public static Singleton GetInstance(string settings)
        {
            if (instance == null)
                instance = new Singleton(settings);
            return instance;
        }
    }
}

