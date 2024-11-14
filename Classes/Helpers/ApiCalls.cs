using System;

namespace FantasyFootballMatchupAnalyzer.Classes.Helpers
{
    public static class ApiCalls
    {
        public static string SleeperUserApiUri => "https://api.sleeper.app/v1/user/";
        public static string SleeperUserLeaguesApiUri(string userId) => 
            $"https://api.sleeper.app/v1/user/{userId}/leagues/nfl/{DateTime.Now.Year.ToString()}";
    }
}
