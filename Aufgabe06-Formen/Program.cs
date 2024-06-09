namespace Aufgabe06_Formen;

class Program
{
    static void Main(string[] args)
    {
        Formen[] formen = new Formen[]
        {
            new Kreis(2.5),
            new Rechteck(3.2, 4.5),
            new Dreieck(2, 4)
        };

        foreach(Formen a in formen)
        {
            a.CalculateArea();
            a.Draw();

        }
    }
}

