using System;

namespace Sandbox.SingletonImplementation
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        public static Singleton Instance { get { return instance; } }

        private Singleton()
        {
            Console.WriteLine("In private ctor!");
        }

        public static void SayHi()
        {
            Console.WriteLine("Hi from Singleton!");
        }
    }
}