using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList{
    class Program{
        static void Main(string[] args){

            ArrayList myArrayList=new ArrayList();
            ArrayList myArraylist2=new ArrayList(100);

            myArrayList.Add(23);
            myArrayList.Add("hello");
            myArrayList.Add("hello");
            myArrayList.Add(13.6666);

            myArrayList.Remove("hello");

            foreach(object obj in myArrayList){
                Console.WriteLine(obj);
            }
            Console.ReadKey();



        }

    }
}