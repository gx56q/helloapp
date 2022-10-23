using System;

namespace helloapp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hello();
            greetWhite();
            greetBlack();
        }

        private static void Hello()
        {
            Console.WriteLine("hello everyone");
        }
        
        private static void greetWhite()
        {
            Console.WriteLine("hello white");
        }
        
        private static void greetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}