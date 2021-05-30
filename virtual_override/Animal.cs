using System;
using System.Collections.Generic;
namespace VirtualOverrideDemo{
    class Animal{
        public string Name{get;set;}
        public int Age{get;set;}
        public bool IsHungry{get;set;} 
    }
    public Animal(string name,int age){
        Name=name;
        age=age;
        IsHungry=true;

    }
    public virtual void MakeSound(){

    }
    public virtual Void Eat(){
        if(IsHungry){
            Console.Write($"{Name}Give Some Khorak!!.");
        }
        else{
            Console.WriteLine($"{Name}nahi devo Khorak!!");
        }
    }
    public virtual void Play(){
        Console.WriteLine($"{Name} is playing  ");
    }
}