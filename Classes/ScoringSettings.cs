using Newtonsoft.Json;

namespace FantasyFootballMatchupAnalyzer.Classes
{
    public class ScoringSettings
    {
        [JsonProperty("sack")]
        public double Sack { get; set; }

        [JsonProperty("fgm_40_49")]
        public double Fgm_40_49 { get; set; }

        [JsonProperty("pass_int")]
        public double PassInt { get; set; }

        [JsonProperty("pts_allow_0")]
        public double DefPtsAllow_0 { get; set; }

        [JsonProperty("pass_2pt")]
        public double Passing2ptConversion { get; set; }

        [JsonProperty("st_td")]
        public double StTd { get; set; }

        [JsonProperty("rec_td")]
        public double ReceivingTd { get; set; }

        [JsonProperty("fgm_30_39")]
        public double Fgm_30_39 { get; set; }

        [JsonProperty("xpmiss")]
        public double ExtraPointMiss { get; set; }

        [JsonProperty("rush_td")]
        public double RushingTd { get; set; }

        [JsonProperty("rec_2pt")]
        public double Receiving2ptConversion { get; set; }

        [JsonProperty("st_fum_rec")]
        public double StandardRumbleRecovery { get; set; }

        [JsonProperty("fgmiss")]
        public double FieldGoalMiss { get; set; }

        [JsonProperty("ff")]
        public double ForcedFumble { get; set; }

        [JsonProperty("rec")]
        public double Reception { get; set; }

        [JsonProperty("pts_allow_14_20")]
        public double DefPtsAllow_14_20 { get; set; }

        [JsonProperty("fgm_0_19")]
        public double Fgm_0_19 { get; set; }

        [JsonProperty("int")]
        public double Interception { get; set; }

        [JsonProperty("def_st_fum_rec")]
        public double DefFumbleRecovery { get; set; }

        [JsonProperty("fum_lost")]
        public double FumbleLost { get; set; }

        [JsonProperty("pts_allow_1_6")]
        public double DefPtsAllow_1_6 { get; set; }

        [JsonProperty("fgm_20_29")]
        public double Fgm_20_29 { get; set; }

        [JsonProperty("pts_allow_21_27")]
        public double DefPtsAllow_21_27 { get; set; }

        [JsonProperty("xpm")]
        public double ExtraPointMade { get; set; }

        [JsonProperty("rush_2pt")]
        public double Rushing2ptConversion { get; set; }

        [JsonProperty("fum_rec")]
        public double FumbleRecovery { get; set; }

        [JsonProperty("def_st_td")]
        public double DefStTd { get; set; }

        [JsonProperty("fgm_50p")]
        public double Fgm_50p { get; set; }

        [JsonProperty("def_td")]
        public double DefTd { get; set; }

        [JsonProperty("safe")]
        public double Safety { get; set; }

        [JsonProperty("pass_yd")]
        public double PassYard { get; set; }

        [JsonProperty("blk_kick")]
        public double BlockedKick { get; set; }

        [JsonProperty("pass_td")]
        public double PassingTd { get; set; }

        [JsonProperty("rush_yd")]
        public double RushingYards { get; set; }

        [JsonProperty("fum")]
        public double Fumble { get; set; }

        [JsonProperty("pts_allow_28_34")]
        public double PtsAllow_28_34 { get; set; }

        [JsonProperty("pts_allow_35p")]
        public double PtsAllow_35p { get; set; }

        [JsonProperty("fum_rec_td")]
        public double FumbleRecoveryTd { get; set; }

        [JsonProperty("rec_yd")]
        public double ReceivingYards { get; set; }

        [JsonProperty("def_st_ff")]
        public double DefStFF { get; set; }

        [JsonProperty("pts_allow_7_13")]
        public double PtsAllow_7_13 { get; set; }

        [JsonProperty("st_ff")]
        public double StFF { get; set; }
    }
}
