using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace UserInfo
{
    public partial class UserInfoModel
    {
        private string displayName;

        [JsonProperty("user_id")]
        public string UserId { get; }

        [JsonProperty("avatar")]
        public string Avatar { get; }

        public UserInfoModel(string displayName)
        {
            this.displayName = displayName;
        }

        //{
        //"avatar":"e7af4deab0289b4f5505646424895246",
        //"cookies":null,
        //"created":null,
        //"currencies":null,
        //"data_updated":null,
        //"deleted":null,
        //"display_name":"RDonnelly",
        //"email":null,
        //"is_bot":false,
        //"metadata":null,
        //"notifications":null,
        //"pending":null,
        //"phone":null,
        //"real_name":null,
        //"solicitable":null,
        //"summoner_name":null,
        //"summoner_region":null,
        //"token":null,
        //"user_id":"986817661701054464",
        //"username":"rdonnelly",
        //"verification":null
        //   }
    }

    public partial class UserInfoModel
    {
        public static UserInfoModel FromJson(string json) => JsonConvert.DeserializeObject<UserInfoModel>(json, UserInfo.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this UserInfoModel self) => JsonConvert.SerializeObject(self, UserInfo.Converter.Settings);
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
