static Main(string [] args){
    int [] nums=new int [10];
    for(int i=0;i<10;i++){
        nums[i]=i;
    }
    int counter=0;
    foreach(int x in nums){
        Cosnole.WriteLine(counter,x);
        counter++;
    }
}
