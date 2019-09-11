using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryLogin
    {
        public class Login
        {
            [JsonProperty("error")]
            public LoginError Error { get; set; }

            public bool IsSuccess { get; set; }
            public string SessionID { get; set; }

            [JsonProperty("time")]
            public DateTimeOffset Time { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }

        public class Data
        {
            [JsonProperty("kind")]
            public string Kind { get; set; }

            [JsonProperty("item")]
            public Item Item { get; set; }

            [JsonProperty("_links")]
            public List<Link> Links { get; set; }
        }

        public class Item
        {
            [JsonProperty("authenticated")]
            public bool Authenticated { get; set; }

            [JsonProperty("fiery")]
            public bool Fiery { get; set; }
        }

        public class Link
        {
            [JsonProperty("rel")]
            public string Rel { get; set; }

            [JsonProperty("href")]
            public Uri Href { get; set; }
        }

        public class LoginError
        {
            [JsonProperty("code")]
            public int Code { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("errors")]
            public List<ErrorElement> Errors { get; set; }
        }

        public class ErrorElement
        {
            [JsonProperty("domain")]
            public string Domain { get; set; }

            [JsonProperty("reason")]
            public string Reason { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }
        }
    }
}
