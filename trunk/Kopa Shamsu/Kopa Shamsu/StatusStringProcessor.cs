using System.Collections.Generic;
using Kopa_Shamsu.Entities;

namespace Kopa_Shamsu
{
    internal class StatusStringProcessor
    {
        private readonly string[] statusStrings;

        public StatusStringProcessor(string statusString)
        {
            statusStrings = statusString.Split('\n');
        }

        public List<ServerParameter> GetServerParameters()
        {
            var serverParameters = new List<ServerParameter>();

            string[] rawParemeters = statusStrings[1].Split('\\');

            for (int i = 1; i < rawParemeters.Length; i += 2)
            {
                var serverParameter = new ServerParameter();
                serverParameter.Parameter = rawParemeters[i];
                serverParameter.Value = rawParemeters[i + 1];
                serverParameters.Add(serverParameter);
            }

            return serverParameters;
        }

        public List<Player> GetPlayers()
        {
            var players = new List<Player>();

            for (int i = 2; i < statusStrings.Length - 1; i++)
            {
                var player = new Player();
                string[] rawPlayer =
                    statusStrings[i].Split(' ');
                player.Kills = rawPlayer[0];
                player.Ping = rawPlayer[1];
                player.Alias = rawPlayer[2].Trim('"');

                players.Add(player);
            }
            return AssignDuplicateNumbers(players);
        }

        public List<Player> AssignDuplicateNumbers(List<Player> players)
        {
            var dictionary = new Dictionary<string, int>();

            foreach (Player player in players)
            {
                if (dictionary.ContainsKey(player.Alias))
                {
                    dictionary[player.Alias]++;

                    if (dictionary[player.Alias] > 0)
                    {
                        player.Alias = player.Alias + "_" + dictionary[player.Alias];
                    }
                }
                else
                {
                    dictionary.Add(player.Alias, 0);
                }
            }

            return players;
        }
    }
}