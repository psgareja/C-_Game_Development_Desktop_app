using System;

namespace input1
{
    class in1
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Console.WriteLine(input);
            Console.Read();

        }
        public static int Calc(){
            Console.WriteLine("Please enter the first number");

            String numInput=Console.ReadLine();

            Console.WriteLine("Second numnber");
            string SecondNo=Console.ReadLine();

            string res=numInput+SecondNo;

            return res; 
        }

    }
}