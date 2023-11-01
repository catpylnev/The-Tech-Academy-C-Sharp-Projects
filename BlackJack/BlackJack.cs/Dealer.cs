using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BlackJack.cs
{
    public class Dealer
    {
        public string name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\kcpyl\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\BlackJack\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            // Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
