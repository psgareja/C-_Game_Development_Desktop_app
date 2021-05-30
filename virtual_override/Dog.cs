using System;
using System.Collections.Generic;

namespace VirtualOverrideDemo{
    class Dog:Animal{
        public bool IsHappy{set;get}
        public Dog(string name ,int age ):base(name,age){
            IsHappy=true;
        }
        public override Eat(){
            base.Eat();
        }
        public override MakeSound(){
            Console.WriteLine("woooooffffff.");
        }
        public override void Play(){
            if(IsHappy){
                base.Play();
            }
        }
    }
}