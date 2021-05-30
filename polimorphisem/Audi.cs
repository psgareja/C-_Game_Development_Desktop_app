 namespace poly
{
    class AUDI:Car{
                private string brand="AUDI";

        public string Model{get;set}
        public AUDI(int hp,string color,string model):base(hp,color){
            
            this.Model=model;



        }
        public new void ShowDetails(){
            Console.WriteLine("Brand" + Brand + "HP "+HP+"Color "+Color);
        }
        public override void Repair(){
            Console.WriteLine("Audi want Repair");
        }

    }
}