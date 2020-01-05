using System;

namespace DoFactory.GangOfFour.Singleton.Structural
{
    /// <summary>
    /// MainApp startup class for Structural / Singleton Design Pattern.
    /// </summary>

    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("s1 et s2 sont la même instance");
                Console.WriteLine("s1 : " + s1.GetHashCode());
                Console.WriteLine("s2 : " + s2.GetHashCode());
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    class Singleton
    {
        private static Singleton _instance;
        private static readonly object _padlock = new object();

        // Constructor is 'protected'
        protected Singleton() { }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}
