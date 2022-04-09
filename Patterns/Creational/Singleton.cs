namespace Patterns.Creational
{
    /// <summary>
    /// Ensure a class has only 1 globally-accessible instance
    /// </summary>
    public class Singleton
    {
        private static readonly Singleton instance = new();

        protected Singleton() { }

        public static Singleton Instance() { return instance; }
    }
}
