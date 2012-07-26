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

            for (int i = 2; i < statusStrings.Length-1; i++)
            {
                Player player = new Player();
                string[] rawPlayer =
                statusStrings[i].Split(' ');
                player.Kills = rawPlayer[0];
                player.Ping = rawPlayer[1];
                player.Alias = rawPlayer[2].Trim('"');

                players.Add(player);
            }
            return players;
        }
    }
}
