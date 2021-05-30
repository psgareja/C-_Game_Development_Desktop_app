 namespace poly
{
    class M3:BMW{
                private string brand="M3";

        public string Model{get;set}
        public M3(int hp,string color,string model):base(hp,color){
            
            this.Model=model;



        }
        public new void ShowDetails(){
            Console.WriteLine("Brand" + Brand + "HP "+HP+"Color "+Color);
        }
        public override void Repair(){
            base.Repair();
        }

    }
}