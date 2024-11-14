using Newtonsoft.Json;
using System.Collections.Generic;

namespace FantasyFootballMatchupAnalyzer.Classes
{
    public class Roster
    {
        int leagueId;

        [JsonProperty("starters")]
        public List<string> starters { get; } = new List<string>();

        [JsonProperty("roster_id")]
        public string RosterId { get; }

        [JsonProperty("players")]
        public List<string> Players { get; } = new List<string>();

        [JsonProperty("owner_id")]
        public string OwnerId { get; }

        public Roster(int leagueId)
        {
            this.leagueId = leagueId;
        }
    }
}
