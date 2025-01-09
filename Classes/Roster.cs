using Newtonsoft.Json;

namespace FantasyFootballMatchupAnalyzer.Classes
{
    public class Roster
    {
        [JsonProperty("starters")]
        public string[] starters { get; set; }

        [JsonProperty("roster_id")]
        public string RosterId { get; set; }

        [JsonProperty("players")]
        public string[] Players { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("league_id")]
        public string LeagueId { get; set; }
    }
}
