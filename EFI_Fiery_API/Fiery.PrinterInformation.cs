using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryPrinterInformation
    {
        public class PrinterInformation
        {
            [JsonProperty("time")]
            public DateTimeOffset Time { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }

        public class Item
        {
            [JsonProperty("disk_available")]
            public long DiskAvailable { get; set; }

            [JsonProperty("disk_total")]
            public long DiskTotal { get; set; }

            [JsonProperty("epoch_time")]
            public long EpochTime { get; set; }

            [JsonProperty("fiery_locale")]
            public string FieryLocale { get; set; }

            [JsonProperty("locale")]
            public string Locale { get; set; }

            [JsonProperty("memory_available")]
            public long MemoryAvailable { get; set; }

            [JsonProperty("memory_total")]
            public long MemoryTotal { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("os_locale")]
            public string OsLocale { get; set; }

            [JsonProperty("serial_number")]
            public string SerialNumber { get; set; }

            [JsonProperty("timezone")]
            public string Timezone { get; set; }

            [JsonProperty("uptime")]
            public long Uptime { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("host")]
            public string Host { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }
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

        public class Link
        {
            [JsonProperty("rel")]
            public string Rel { get; set; }

            [JsonProperty("href")]
            public Uri Href { get; set; }
        }
    }
}
