using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryServer
    {
        public enum MethodEnum
        {
            none,
            restart,
            reboot,
            stop,
            clear,
            pause,
            resume,
            cancelprinting,
            cancelripping
        }

        public enum ServicesEnum
        {
            none,
            jobs,
            accounting,
            configuration
        }

        public class PrinterServerStatus
        {
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
            [JsonProperty("fiery")]
            public string Fiery { get; set; }

            [JsonProperty("started", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Started { get; set; }
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
