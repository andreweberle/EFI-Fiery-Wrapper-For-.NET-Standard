using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryDetail
    {
        public class PrinterDetail
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
            [JsonProperty("DST")]
            public long Dst { get; set; }

            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("date_format")]
            public string DateFormat { get; set; }

            [JsonProperty("default_paper_size")]
            public string DefaultPaperSize { get; set; }

            [JsonProperty("disk_available")]
            public long DiskAvailable { get; set; }

            [JsonProperty("disk_total")]
            public long DiskTotal { get; set; }

            [JsonProperty("epoch_time")]
            public long EpochTime { get; set; }

            [JsonProperty("fiery_locale")]
            public string FieryLocale { get; set; }

            [JsonProperty("fiery_locales")]
            public List<string> FieryLocales { get; set; }

            [JsonProperty("locale")]
            public string Locale { get; set; }

            [JsonProperty("measurement_unit")]
            public string MeasurementUnit { get; set; }

            [JsonProperty("memory_available")]
            public long MemoryAvailable { get; set; }

            [JsonProperty("memory_total")]
            public long MemoryTotal { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("number_format")]
            public string NumberFormat { get; set; }

            [JsonProperty("os_locale")]
            public string OsLocale { get; set; }

            [JsonProperty("os_locales")]
            public List<string> OsLocales { get; set; }

            [JsonProperty("productid")]
            public long Productid { get; set; }

            [JsonProperty("serial_number")]
            public string SerialNumber { get; set; }

            [JsonProperty("time")]
            public DateTimeOffset Time { get; set; }

            [JsonProperty("timezone")]
            public string Timezone { get; set; }

            [JsonProperty("timezones")]
            public List<Timezone> Timezones { get; set; }

            [JsonProperty("uptime")]
            public long Uptime { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("host")]
            public string Host { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }
        }

        public class Timezone
        {
            [JsonProperty("DST")]
            public long Dst { get; set; }

            [JsonProperty("offset")]
            public long Offset { get; set; }

            [JsonProperty("timezone")]
            public string TimezoneTimezone { get; set; }
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