using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebtkarat.Tournament
{
    interface Team
    {
        string GetName();

        double GetScore();

        bool IsWinner { get; set; }

        void AddPlayer(Player player);
        void RemovePlayer(Player player);
    }
}
