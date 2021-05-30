 namespace poly
{
    class BMW:Car{
                private string brand="BMW";

        public string Model{get;set}
        public BMW(int hp,string color,string model):base(hp,color){
            
            this.Model=model;



        }
        public new void ShowDetails(){
            Console.WriteLine("Brand" + Brand + "HP "+HP+"Color "+Color);
        }
        public override void Repair(){
            Console.WriteLine("BMW Want repair.");
        }

    }
}