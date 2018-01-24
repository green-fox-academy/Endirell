using System.Collections.Generic;
using System.Linq;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private List<Player> players;

        public TennisGame3(string player1Name, string player2Name)
        {
            players = new List<Player>() { new Player(player1Name), new Player(player2Name) };
        }

        public string GetScore()
        {
            if (IsUnderDeuce())
            {
                return (IsEqual()) ? GetPlayersScoreString(0) + "-All" : GetPlayersScoreString(0) + "-" + GetPlayersScoreString(1);
            }
            else
            {
                if (IsEqual())
                    return "Deuce";
                return (!IsWon()) ? "Advantage " + GetLeaderName() : "Win for " + GetLeaderName();
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == players[0].Name)
                players[0].Score += 1;
            else
                players[1].Score += 1;
        }

        public bool IsUnderDeuce()
        {
            return (players[0].Score < 4 && players[1].Score < 4) && (players[0].Score + players[1].Score < 6);
        }

        public bool IsEqual()
        {
            return players[0].Score == players[1].Score;
        }

        public string GetLeaderName()
        {
            var player = players.FirstOrDefault(p => p.Score == players.Max(pp => pp.Score));
            return player.Name;
        }

        public bool IsWon()
        {
            if (!IsUnderDeuce())
            {
                return (players[0].Score - players[1].Score) * (players[0].Score - players[1].Score) > 1;
            }
            return false;
        }

        public string GetPlayersScoreString(int index)
        {
            return ScoreValues.Name[players[index].Score];
        }
    }
}