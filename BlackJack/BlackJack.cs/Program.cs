using System;
using System.Collections.Generic;

namespace BlackJack.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Catherine", "Quincy", "Emily" };
            //game.ListPlayers();
            //Console.ReadLine();

            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Catherine";
            game += player;
            game -= player;

            Deck deck = new Deck();
            deck.Shuffle(3);//shuffled three times

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
