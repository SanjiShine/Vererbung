using System;
namespace Aufgabe03_Kartenspiel
{
	public class Card
	{
        public string Name { get; set; }

        public Card(string name)
        {
            this.Name = name;
        }

    }

    public class Item : Card
    {
        public int Value { get; set; }

        public Item(string name, int value) : base(name)
        {
            this.Value = value;
        }
    }

    public class Event : Card
    {
        public string InfoText { get; set; }

        public Event(string name, string infoText) : base(name)
        {
            this.InfoText = infoText;
        }
    }

    public class Action : Card
    {
        public Action(string name) : base(name) { }

        public void Sell(Item karte)
        {
            Console.WriteLine($"Ich verkaufe {karte.Name} für {karte.Value} Goldstücke.");
        }

        public void PerformAction(Event karte)
        {
            Console.WriteLine($"Action: {karte.InfoText}");
        }
    }





}

