namespace Patterns
{
    public class Singleton
    {
        private static readonly Singleton instance = new();

        protected Singleton() { }

        public static Singleton Instance() { return instance; }
    }
}
