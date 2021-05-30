using System;
using System.Collections.Generic;

namespace Inheritance{
    class Radio:ElectricalDevice{
        
        
        public Radio(bool isOn,string brand):base(isOn,brand)
        {
           
        }

       
        public void ListenRadio(){
        if(IsOn){
            Console.WriteLine("Listening Radio!.");
        }
        else{
            Console.WriteLine("Switchon Radio!.");
        }
    }
    }
}