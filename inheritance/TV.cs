using System;
using System.Collections.Generic;

namespace Inheritance{
    class Tv:ElectricalDevice{
       
        public TV(bool isOn,string brand):base(isOn,brand){
            
        }
        
        public WatchTV(){
            if(IsOn){
                Console.WriteLine("TV is on!.");
            }
            else{
                Console.WriteLine("TV is OFF");
            }
        }

    }
}