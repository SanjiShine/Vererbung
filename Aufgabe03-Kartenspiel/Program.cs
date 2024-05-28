namespace Aufgabe03_Kartenspiel;

class Program
{
    static void Main(string[] args)
    {
        CardStack stack = new CardStack();
        // Eine neue Instanz von Event anlegen, mit Werten füllen und danach // auf den Stapel legen

        Card newCard = new Event("Regen", "Es regnet sehr stark.");
        stack.AddCard(newCard);
        // Noch eine Karte anlegen und auf den Stapel usw.
        newCard = new Item("Regenschirm", 100);
        stack.AddCard(newCard);

        newCard = new Action("Aktionskarte");
       // stack.AddCard(newCard);

        // Ok, lets play and take two cards!
        try
        {
            Card firstCard = stack.TakeCard();


            Card secondCard = stack.TakeCard();

            // Wir haben jetzt zwei Karten und entscheiden was zu tun ist, z. B.
            if (firstCard is Action)
            {
                ((Action)firstCard).Sell((Item)secondCard);
            }

            // Noch eine Karte nehmen
            Card thirdCard = stack.TakeCard();

            newCard = new Action("Aktionskarte");
            stack.AddCard(newCard);

            Card fourthCard = stack.TakeCard();

            if (fourthCard is Action)
            {
                ((Action)fourthCard).PerformAction((Event)thirdCard);
            }

            // Wir schummeln ein wenig, da wir wissen, was kommen muss.
            // Wenn das Programm ausgeführt wird, kann jedoch auch ein anderer // Typ Karte kommen.
            // DANN BRICHT DAS PROGRAMM MIT EINEM LAUFZEITFEHLER AB!!!!!
        }
        catch (Exception e)
        {
            Console.WriteLine($"Fehler: {e.Message}");
        }
    }
}

