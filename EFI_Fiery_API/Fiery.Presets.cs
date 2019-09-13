using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFI_Fiery_API
{
    public class FieryPrinterPresets
    {
        public class PrinterPresets
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

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("factory")]
            public bool Factory { get; set; }

            [JsonProperty("available")]
            public bool Available { get; set; }

            [JsonProperty("editable")]
            public bool Editable { get; set; }

            [JsonProperty("removable")]
            public bool Removable { get; set; }

            [JsonProperty("original default name")]
            public string OriginalDefaultName { get; set; }

            [JsonProperty("timestamp created")]
            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            public DateTime TimestampCreated { get; set; }

            [JsonProperty("timestamp modified")]
            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            public DateTime TimestampModified { get; set; }
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
