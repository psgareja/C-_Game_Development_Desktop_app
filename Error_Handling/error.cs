using Stsrem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryandCatch{
    class Program{
        static void Main(string [] args){
            Console.WriteLine("Please enter a number ");
            string userInput=Console.ReadLine();
            
            try{
                int userInputAsInt=int.Parse(userInput);

            }catch(FormatExceprion)
            {
            Console.WriteLine("Format Exeption!!.");
            }catch(OverFlowException)
            {
                Console.WriteLine("Overflow Exception");
            }finally{
                Console.WriteLine("this is called anyways");

            }
            console.ReadKey();
        }
    }
}