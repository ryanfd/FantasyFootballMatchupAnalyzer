using FantasyFootballMatchupAnalyzer.Classes;
using Newtonsoft.Json;

/// <summary>
/// Summary description for Class1
/// </summary>
public class FantasyFootballLeague
{
    public string ImageDisplayLink => $"https://sleepercdn.com/avatars/thumbs/{Avatar}";

    [JsonProperty("league_id")]
    public string LeagueId { get; set; }

    [JsonProperty("total_rosters")]
    public string TotalRosters { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("season_type")]
    public string SeasonType { get; set; }

    [JsonProperty("season")]
    public string Season { get; set; }

    [JsonProperty("score_settings")]
    public object ScoreSettings { get; set; }

    //[JsonProperty("roster_positions")]
    //public Roster[] RosterPositions { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("draft_id")]
    public string DraftId { get; set; }

    [JsonProperty("avatar")]
    private string Avatar { get; set; }
}
