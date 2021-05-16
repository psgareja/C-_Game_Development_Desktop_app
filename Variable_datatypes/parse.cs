using System;
namespace Hello {
    class Parse{
        static void Main(string[] args){
            string myString='15';
            string mySecondString='13';
            int num1=Int32.Parse(myString);
            int num2=Int32.Parse(mySecondString);
            string result=num1+num2;
            Console.WriteLine(result);
            Console.Read();

        }
    }
}