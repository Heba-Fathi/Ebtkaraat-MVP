using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebtkarat.Tournament
{

    class TeamA : Team
    {

        List<Player> players;

        bool Team.IsWinner { get; set; }

        public TeamA()
        {
            players = new List<Player>();
        }


        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }
        public string GetName()
        {
            return "Team A";
        }



        public double GetScore()
        {
            double score = 0;
            foreach (var player in players)
            {
                score += player.Score;
            }
            return score;
        }

        public bool IsWinner()
        {
            return true;
        }


    }


}
