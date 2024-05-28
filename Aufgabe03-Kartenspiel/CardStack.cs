using System;
namespace Aufgabe03_Kartenspiel
{
    public class CardStack
    {
        Element? head;

        public class Element
        {
            public Card Card { get; set; }
            public Element? Successor { get; set; }

            public Element(Card card)

            {
                this.Card = card;
            }
        }

        public void AddCard(Card card)
        {
            Element newCard = new Element(card);
            newCard.Successor = head;
            head = newCard;
        }

        public Card TakeCard()
        {
            if (head == null) throw new Exception("Keine Karten mehr verfügbar!");
    
            Card ret = head.Card;
            head = head.Successor;
            return ret;
        }
    }
}

