using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyBeat
{
    interface IScoreBoard
    {
        void SinglePlayer(string user, int score, int time);
        void Multiplayer(string winner, int winnerscore, int winnertime, string loser, int loserscore, int losertime, string pone, string ptwo);
    }
}
