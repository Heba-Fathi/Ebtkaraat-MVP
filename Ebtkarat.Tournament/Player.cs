using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebtkarat.Tournament
{
   public class Player
    {
         Sport _sport;
       
        public Player(Sport sport)
        {
            _sport = sport;
          
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; } //unique
                                             // Team TeamName { get; set; }


        public Position Position { get; set; }
        
        
        public double Score { 
            get { return _sport.Calculate(Position) ; }
          
        }


        public double TotalScore { get; set; }

        
    }
}
