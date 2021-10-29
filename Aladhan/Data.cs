using System.Text.Json.Serialization;

namespace bot.Dto.Aladhan
{     
// Al Azan saytining requstidagi json fayllar 
    public class Data
    {
        [JsonPropertyName("timings")]
        public Timings Timings { get; set; }

        [JsonPropertyName("date")]
        public Date Date { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}