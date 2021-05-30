static void main(strings [] args){
    var cars=new List<car>
    {
        new AUDI(200,"blue","A4");
        new BMW(250,"Red","M3")

    };
    foreach(var car in cars){
        car.Repiar();
    }
    Car bmw23=new BMW(240,"hl","u");

    Car carB=new (Car)bmw23;
    carB.ShowDetails();
    bmw23.ShowDetails();
    M3 mym=new M3(2000,"y","5");
    mym.SetCardIdInfo(123,"gareja");
    mym.GetCardIDInfor();
    mym.Repair();
    Console.ReadKey();

    

}