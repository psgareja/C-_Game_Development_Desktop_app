using System;
using System.collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace class__basic{
    class Human{
        public string firstName;
        public string lastName;
        public Human(){
            Console.WriteLine("Object Created!.");

        }
        public Human(string firstname,string lastname){
            firstName=firstname;
            lastName=lastname;

        }
        public void IntroduceMySelf(){
            Console.WriteLine("Hi {0}",firstName);
        }

    }
    class Program{
        static void Main(string [] args){
            Human pradip=new Human("pradip","gareja ");
            Human BasicHuman=new Human();
            pradip.IntroduceMySelf();
            Console.ReadKey();

        }
    }
}