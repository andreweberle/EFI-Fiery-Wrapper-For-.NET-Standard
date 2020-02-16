using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFI_Fiery_API
{
    public class FieryQueue
    {
        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
    public partial class Data
    {
        [JsonProperty("totalItems")]
        public long TotalItems { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("factory")]
        public bool Factory { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }
    }
}
