using System;

namespace FantasyFootballMatchupAnalyzer.Classes.Helpers
{
    public static class ApiCalls
    {
        public static string SleeperUserApiUri => "https://api.sleeper.app/v1/user/";
        public static string SleeperUserCurrentYearLeaguesApiUri(string userId) => 
            $"https://api.sleeper.app/v1/user/{userId}/leagues/nfl/{DateTime.Now.Year.ToString()}";
        public static string SleeperLeagueRosterApiUri(string leagueId) => $"https://api.sleeper.app/v1/league/{leagueId}/rosters";
    }
}
