// -----------------------------------------------------------------------------------------------
//  Singleton.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace SingletonLive
{
    public class Singleton
    {
        private static readonly Mutex mutex;
        // Private statisk egen instansiering av klassen
        private static Singleton instance;
        // Enbart för att testa
        public string Text { get; set; } = "";
        // Privat constructor som gör att new inte fungerar utanför klassen
        private Singleton() {}
        // Hämta instans av klassen
        public static Singleton GetInstance()
        {
            if (instance==null)
            {
                lock (mutex)
                {
                    if (instance == null) instance = new();
                }
            }
            return instance;
        }
    }
}
