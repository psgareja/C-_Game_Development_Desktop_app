using System;

namespace Hello {
    class Write {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecial("hello");
        }
        public static void WriteSomething(){
            Console.WriteLine("Hello!!.");
            Console.Read();
        }

        public static WriteSomethingSpecial(string myString)
        {
            Console.WriteLine(myString);
            Console.Read();

        }
    }
}