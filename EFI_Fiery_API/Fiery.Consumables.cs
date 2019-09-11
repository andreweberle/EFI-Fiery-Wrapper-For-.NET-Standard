using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryComsumables
    {
        public class PrinterComsumables
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
            [JsonProperty("colorants")]
            public List<Colorant> Colorants { get; set; }

            [JsonProperty("trays")]
            public List<Tray> Trays { get; set; }
        }

        public class Colorant
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("i18n")]
            public string I18N { get; set; }

            [JsonProperty("color")]
            public string Color { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }
        }

        public class Tray
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("trayid")]
            public long Trayid { get; set; }

            [JsonProperty("i18n")]
            public string I18N { get; set; }

            [JsonProperty("dimensions")]
            public List<long> Dimensions { get; set; }

            [JsonProperty("lef")]
            public bool Lef { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }

            [JsonProperty("attributes")]
            public Attributes Attributes { get; set; }

            [JsonProperty("pcmid")]
            public long Pcmid { get; set; }
        }

        public class Attributes
        {
            [JsonProperty("EFMediaCoatSide")]
            public string EfMediaCoatSide { get; set; }

            [JsonProperty("EFMediaCoatType")]
            public string EfMediaCoatType { get; set; }

            [JsonProperty("EFMediaColor")]
            public string EfMediaColor { get; set; }

            [JsonProperty("EFMediaCount")]
            public long EfMediaCount { get; set; }

            [JsonProperty("EFMediaFinish")]
            public string EfMediaFinish { get; set; }

            [JsonProperty("EFMediaHoleType")]
            public string EfMediaHoleType { get; set; }

            [JsonProperty("EFMediaType")]
            public string EfMediaType { get; set; }

            [JsonProperty("EFMediaWeight")]
            public string EfMediaWeight { get; set; }

            [JsonProperty("PageSize")]
            public string PageSize { get; set; }
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
