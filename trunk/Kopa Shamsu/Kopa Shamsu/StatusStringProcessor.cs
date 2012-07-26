using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kopa_Shamsu.Entities;

namespace Kopa_Shamsu
{
    class StatusStringProcessor
    {
        private string[] statusStrings;

        public StatusStringProcessor(string statusString)
        {
            statusStrings = statusString.Split('\n');
        }

        public List<ServerParameter> GetServerParameters()
        {
            List<ServerParameter> serverParameters = new List<ServerParameter>();

            string[] rawParemeters = statusStrings[1].Split('\\');

            for (int i=1; i<rawParemeters.Length;i+=2)
            {
                    ServerParameter serverParameter = new ServerParameter();
                    serverParameter.Parameter = rawParemeters[i];
                    serverParameter.Value = rawParemeters[i+1];
                    serverParameters.Add(serverParameter);
            }

            return serverParameters;
        }

        public List<Player>  GetPlayers()
        {
            List<Player> players = new List<Player>();

            string[] rawPlayers = statusStrings[2].Split(' ');

            if (rawPlayers.Length < 3) return null;

            for (int i = 0; i < rawPlayers.Length;i+=3)
            {
                Player player = new Player();
                player.Kills = rawPlayers[i];
                player.Ping = rawPlayers[i + 1];
                player.Alias = rawPlayers[i + 2].Trim('"');

                players.Add(player);
            }
            return players;
        }
    }
}
