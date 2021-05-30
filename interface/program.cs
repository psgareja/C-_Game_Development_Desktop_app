using system;

namespace Interface
{
    class Program{
        Console.WriteLine("Hello World!");
        Ticket t1=new Ticket(10);
        Ticket t2=new Ticket2(10);
        System.Console.WriteLine(t2.Equal(t1));

    }
}