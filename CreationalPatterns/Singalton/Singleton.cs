namespace CreationalPatterns.Singalton
{
    public  class Singleton
    {
        private static volatile Singleton _instance;
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        public string TestInt { get; set; }
    }
}
