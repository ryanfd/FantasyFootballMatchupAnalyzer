using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;

namespace UserInfo
{
    public partial class UserInfoModel
    {
        public List<FantasyFootballLeague> UserLeagues { get; set; }
        public string AvatarDisplayLink => $"https://sleepercdn.com/avatars/thumbs/{Avatar}";

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class UserInfoModel
    {
        public static UserInfoModel FromJson(string json) => JsonConvert.DeserializeObject<UserInfoModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this UserInfoModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
                {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
        };
    }
}
