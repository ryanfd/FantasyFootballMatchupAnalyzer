using Newtonsoft.Json;

namespace FantasyFootballMatchupAnalyzer.Classes
{
    public class Roster
    {
        int leagueId;

        [JsonProperty("starters")]
        public string[] starters { get; set; }

        [JsonProperty("roster_id")]
        public string RosterId { get; set; }

        [JsonProperty("players")]
        public string[] Players { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        //public Roster(int leagueId)
        //{
        //    this.leagueId = leagueId;
        //}
    }
}
