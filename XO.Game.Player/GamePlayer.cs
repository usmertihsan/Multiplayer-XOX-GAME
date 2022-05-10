using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.Game.Player
{
    public class GamePlayer
    {
        public GamePlayer() { }
        public string playerName { get; set; }
        public int playerScore;
        public string playerMark;
        
        public string GetName() // gets name of player
        {
            return playerName;
        }

        public void SetPlayerName(string name)
        {
            playerName = name;
        }


        public void IncreaseScore() // sets score increase one
        {
            playerScore += 1;
        }

        public int GetScore() // gets score of player
        {
            return playerScore;
        }

        public string GetPlayerMark()
        {
            return playerMark;
        }

    }

    


}
