using System;
namespace Aufgabe02_Tier
{
	public abstract class Tier
	{
		public string Name { get; set; }

		public abstract void MacheAufDichAufmerksam();

        public Tier(string name)
        {
            Name = name;
        }
    }

	public class Hund : Tier
	{
        public Hund(string name) : base(name) { }

        public override void MacheAufDichAufmerksam()
		{
			Console.WriteLine("Ich bin ein Hund und mache Wau"); ;
		}
    }

	public class Katze : Tier
	{
        public Katze(string name) : base(name) { }

        public override void MacheAufDichAufmerksam()
        {
            Console.WriteLine("Ich bin eine Katze und mache Miau"); 
        }
    }

	public class Maus : Tier
	{
        public Maus(string name) : base(name) { }

        public override void MacheAufDichAufmerksam()
        {
            Console.WriteLine("Ich bin eine Maus und mache Piep"); 
        }
    }


}

