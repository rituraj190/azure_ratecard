namespace ClassLibrary1
{
    using Newtonsoft.Json;
    public class ResponseData
    {
        [JsonProperty("token_type")]
        public string Token_type { get; set; }

        [JsonProperty("expires_in")]
        public string Expires_in { get; set; }

        [JsonProperty("ext_expires_in")]
        public string Ext_expires_in { get; set; }

        [JsonProperty("expires_on")]
        public string Expires_on { get; set; }

        [JsonProperty("not_before")]
        public string Not_before { get; set; }

        [JsonProperty ("resource")]
        public string Resource { set; get; }

        [JsonProperty ("access_token")]
        public string Access_token { set; get; }



        }
    }

