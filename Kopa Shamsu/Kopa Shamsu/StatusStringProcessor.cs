using System.Collections.Generic;
using System.Text;
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
            List<ServerParameter> serverParameters = new List<ServerParameter>();

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
            List<Player> players = new List<Player>();

            for (int i = 2; i < statusStrings.Length - 1; i++)
            {
                var player = new Player();

                string[] rawPlayerName =
                    statusStrings[i].Split('"');
                player.Alias = RemoveSpacesAndColorCodes(rawPlayerName[1]);

                string[] rawPlayerStats = rawPlayerName[0].Split(' ');
                player.Kills = rawPlayerStats[0];
                player.Ping = rawPlayerStats[1];
                

                players.Add(player);
            }
            return AssignDuplicateNumbers(players);
        }

        private List<Player> AssignDuplicateNumbers(List<Player> players)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

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

        private string RemoveSpacesAndColorCodes(string alias)
        {
            char[] aliasArray = alias.ToCharArray();
            StringBuilder aliasBuilder = new StringBuilder();

            for (int i = 0; i < aliasArray.Length;i++)
            {
                if (aliasArray[i] == ' ')
                {
                    i++;
                }
                if (aliasArray[i] == '^')
                {
                    i+=2;
                }
                aliasBuilder.Append(aliasArray[i]);
            }

                return aliasBuilder.ToString();
        }
    }
}