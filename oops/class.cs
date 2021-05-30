using System;
using System.collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace class__basic{
    class Human{
        public string firstName;
        public void IntroduceMySelf(){
            Console.WriteLine("Hi {0}",firstName);
        }

    }
    class Program{
        static void Main(string [] args){
            Human pradip=new Human();
            pradip.firstName='pradip';
            pradip.IntroduceMySelf();
            Console.ReadKey();
        }
    }
}