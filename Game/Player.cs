using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public Player() { }
        public Player(int score, string playerName) 
        {
            Score = score;
            PlayerName = playerName;
        }
    }
}
