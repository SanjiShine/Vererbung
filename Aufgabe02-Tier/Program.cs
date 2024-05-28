namespace Aufgabe02_Tier;

class Program
{
    static void Main(string[] args)
    {
        Tier[] meinKleinerZoo = new Tier[]
            {
                new Hund("Bobo"),
                new Katze("Sushi"),
                new Maus("Jerry")
            };

        foreach (var tier in meinKleinerZoo)
        {
            tier.MacheAufDichAufmerksam();
        }
    }

}

