namespace Aufgabe01_Vehicle;

class Program
{
    static void Main(string[] args)
    {
        SailingShip sailingShip1 = new SailingShip("A123", "A-10-1234", "Phi Phi", 2);
        sailingShip1.SayId();

        Console.WriteLine(sailingShip1);
       
    }
}

