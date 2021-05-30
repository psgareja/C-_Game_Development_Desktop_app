class Dog{
    public strong Name{get;set;}
    public bool IsNaughtyDog{get;set}
    public Dog(string name,bool isNaughtyDog){
        this.Name=name;
        this.IsNaughtyDog=isNaughtyDog;
    }
    public void GiveTreat(int numberOfTreats){
        Console.WriteLine($"Dog:{0} said woof {1} times",Name,numberOfTreats);
    }
}

class DogShelter:IEnumerable<Dog>{
    public List<Dog> dogs;
    public List<Dog> dogs;
    public DogShelter(){
        dogs=new List<Dog>(){
            new Dog("Herro",false);
            new Dog("Hii",true);
            new Dog("oreo",false);
        }
        IEnumerator<Dog> IEnumrable<DOG>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw ("Hello");

        }

    }
}