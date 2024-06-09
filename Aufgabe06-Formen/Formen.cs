using System;
namespace Aufgabe06_Formen
{
	public abstract class Formen
	{
		public abstract void CalculateArea();
		public abstract void Draw();
	}

	public class Kreis : Formen 
	{
		double Radius { get; set; }

		public Kreis(double radius)
		{
			this.Radius = radius;
		}

		public override void CalculateArea()
		{
			double flaeche = Math.PI * Math.Pow(Radius, 2);
			Console.WriteLine($"Fläche Kreis: {flaeche:f2}");
		}

        public override void Draw()
        {
			Console.WriteLine("Ich bin ein Kreis.");
        }
    }

	public class Rechteck : Formen
	{
		double Laenge { get; set; }
		double Breite { get; set; }

		public Rechteck(double laenge, double breite)
		{
			this.Laenge = laenge;
			this.Breite = breite;
		}

        public override void CalculateArea()
        {
			double flaeche = this.Laenge * this.Breite;
            Console.WriteLine($"Fläche Rechteck: {flaeche:f2}");
        }

        public override void Draw()
        {
            Console.WriteLine("Ich bin ein Rechteck.");
        }
    }

    public class Dreieck : Formen
    {
        double Grundfaeche { get; set; }
        double Hoehe { get; set; }

        public Dreieck(double grundfaeche, double hoehe)
        {
            this.Grundfaeche = grundfaeche;
            this.Hoehe = hoehe;
        }

        public override void CalculateArea()
        {
            double flaeche = 0.5 * this.Grundfaeche * this.Hoehe; 
            Console.WriteLine($"Fläche Dreieck: {flaeche:f2}");
        }

        public override void Draw()
        {
            Console.WriteLine("Ich bin ein Dreieck.");
        }
    }
}

