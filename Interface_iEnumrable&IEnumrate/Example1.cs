namespace MyNamespace
{
    class program{
        static void Main(string[] args){
            IEnumerable<int> unknownCollection;
            unknownCollection=GetCollection(1);
            Console.WriteLine("This is a list<> ");
            foreach(int num unknownCollection){
                Console.Write(num+" ");
            }

            Console.WriteLine("");
            unknownCollection=GetCollection(2);

            Console.WriteLine("this is a Queue ");
            foreach(int num in unknownCollection){
                Console.Write(num+"");
                
            }
        }

        static IEnumerable<int> GetCollection<int option>
        {
            List<int> numebrsList=new List<int> (){1,2,3,4,5};
            Queue<int> numbersQueue=new Queue<int>();
            numbersQueue.Enqueue(1);
            numbersQueue.Enqueue(2);
            numbersQueue.Enqueue(3);
            numbersQueue.Enqueue(4);
            numbersQueue.Enqueue(5);

            if(option==1){
                return numebrsList;
            }
            else if(option==2){
                return numbersQueue;
            }
            else{
                return new int[] {11,12,13,14,15};
            }




            
        }
    }
}