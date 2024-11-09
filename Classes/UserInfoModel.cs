using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace UserInfo
{
    public partial class UserInfoModel
    {
        public string AvatarDisplayLink => $"https://sleepercdn.com/avatars/thumbs/{Avatar}";

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("cookies")]
        public object Cookies { get; set; }

        [JsonProperty("created")]
        public object Created { get; set; }

        [JsonProperty("currencies")]
        public object Currencies { get; set; }

        [JsonProperty("data_updated")]
        public object DataUpdated { get; set; }

        [JsonProperty("deleted")]
        public object Deleted { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("notifications")]
        public object Notifications { get; set; }

        [JsonProperty("pending")]
        public object Pending { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("real_name")]
        public object RealName { get; set; }

        [JsonProperty("solicitable")]
        public object Solicitable { get; set; }

        [JsonProperty("summoner_name")]
        public object SummonerName { get; set; }

        [JsonProperty("summoner_region")]
        public object SummonerRegion { get; set; }

        [JsonProperty("token")]
        public object Token { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("verification")]
        public object Verification { get; set; }
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
