﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public Player(string name, int beginingBalance)
        {
            Hand = new List<Card>();
            Balance = beginingBalance;
            Name = name;
        }
        private List<Card> _Hand = new List<Card>();
        public List<Card> Hand { get { return _Hand; } set { _Hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet (int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                    return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public static Game operator+ (Game game, Player Player)
        {
            game.Players.Add(Player);
            return game;
        }
        public static Game operator- (Game game, Player Player)
        {
            game.Players.Remove(Player);
            return game;
        }
    }
}
