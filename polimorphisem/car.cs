using System;
using System.Collections.Generic;
using System.Collections;
namespace car{
    class Car{
        public int HP { get; set; }
        public string Color{get;set}
         protected CardIDInfo cardIDInfo=new CardIDInfo();
         public void SetCardIdInfo(int idno,string owner){
             cardIDInfo.IDNo=idno;
             cardIDInfo.Owner=owner;
         }
          public void GetCardIDInfor(){
              Console.WriteLine($"Card has ID Of {0} and it is owned by {1}",cardIDInfo.IDNO,cardIDInfo.owner);
          }
        public Car(int hp,string color){
            this.HP=hp;
            this.Color=color;
        }

        
        public void ShowDetails(){
            Console.WriteLine("HP "+HP+"Color"+Color);
        }
        public virtual 
        void Repair(){
            Console.Write("Car was Repair");
        }
    }
}