using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryDevices
    {
        public class PrinterDevices
        {
            [JsonProperty("time")]
            public DateTimeOffset Time { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }

        public class Data
        {
            [JsonProperty("totalItems")]
            public long TotalItems { get; set; }

            [JsonProperty("kind")]
            public string Kind { get; set; }

            [JsonProperty("items")]
            public List<Item> Items { get; set; }

            [JsonProperty("_links")]
            public List<Link> Links { get; set; }
        }

        public class Item
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("jobs")]
            public List<object> Jobs { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("online")]
            public bool Online { get; set; }

            [JsonProperty("prettyname")]
            public string Prettyname { get; set; }

            [JsonProperty("status")]
            public Status Status { get; set; }
        }

        public class Status
        {
            [JsonProperty("dup status message")]
            public string DupStatusMessage { get; set; }

            [JsonProperty("idle")]
            public string Idle { get; set; }

            [JsonProperty("lcd status")]
            public string LcdStatus { get; set; }

            [JsonProperty("printing")]
            public string Printing { get; set; }

            [JsonProperty("sample print")]
            public string SamplePrint { get; set; }

            [JsonProperty("status message")]
            public string StatusMessage { get; set; }
        }

        public class Link
        {
            [JsonProperty("rel")]
            public string Rel { get; set; }

            [JsonProperty("href")]
            public Uri Href { get; set; }
        }
    }
}
