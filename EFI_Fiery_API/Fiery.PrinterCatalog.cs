using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFI_Fiery_API
{
    public class FieryPrinterCatalog
    {
        public class PpdSettings
        {
            public string EFMediaCoatSide { get; set; }
            public string EFMediaCoatType { get; set; }
            public string EFMediaColor { get; set; }
            public string EFMediaCount { get; set; }
            public string EFMediaFinish { get; set; }
            public string EFMediaHoleType { get; set; }
            public string EFMediaType { get; set; }
            public string EFMediaWeight { get; set; }
            public string PageSize { get; set; }
        }

        public class Item
        {
            [JsonProperty("id")]
            public long id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
            public string BackCoatings { get; set; }
            public string BackColorProfile { get; set; }
            public string BackColorProfile2 { get; set; }
            public string BackColorProfile3 { get; set; }
            public string BackColorProfile4 { get; set; }
            public string BackColorProfile5 { get; set; }
            public string BackGlossValue { get; set; }
            public string Brand { get; set; }
            public string Brightness { get; set; }
            public string CIETint { get; set; }
            public string CIEWhiteness { get; set; }
            public string Dimension { get; set; }
            public string EngineMID { get; set; }
            public string FeedDirection { get; set; }
            public string FrontCoatings { get; set; }
            public string FrontColorProfile { get; set; }
            public string FrontColorProfile2 { get; set; }
            public string FrontColorProfile3 { get; set; }
            public string FrontColorProfile4 { get; set; }
            public string FrontColorProfile5 { get; set; }
            public string FrontGlossValue { get; set; }
            public string Grade { get; set; }
            public string GrainDirection { get; set; }
            public string HoleType { get; set; }
            public string ImagableSide { get; set; }
            public string LabColorValue { get; set; }
            public string LockingLevel { get; set; }
            public string MGID { get; set; }
            public string MID { get; set; }
            public string MediaColorName { get; set; }
            public string MediaColorNameDetails { get; set; }
            public string MediaSetCount { get; set; }
            public string MediaType { get; set; }
            public string MediaTypeDetails { get; set; }
            public string MediaUnit { get; set; }
            public string OEM1 { get; set; }
            public string OEM2 { get; set; }
            public string OEM3 { get; set; }
            public string OEM4 { get; set; }
            public string OEM5 { get; set; }
            public string Opacity { get; set; }
            public string OpacityLevel { get; set; }
            public string Polarity { get; set; }
            public string PrePrinted { get; set; }
            public string PrintingTechnology { get; set; }
            public string ProductID { get; set; }
            public string Publish { get; set; }
            public string RecycledPercentage { get; set; }
            public string RollDiameter { get; set; }
            public string ShrinkIndex { get; set; }
            public string StockType { get; set; }
            public string TabEdge { get; set; }
            public string TabExtensionDistance { get; set; }
            public string TabOffset { get; set; }
            public string TabSetCollationOrder { get; set; }
            public string TabShapeBlob { get; set; }
            public string TabWidth { get; set; }
            public string TabsPerBank { get; set; }
            public string Texture { get; set; }
            public string Thickness { get; set; }
            public string TrayNo { get; set; }
            public string Weight { get; set; }

            [JsonProperty("ppd_settings")]
            public PpdSettings PpdSettings { get; set; }
        }

        public class Link
        {
            [JsonProperty("rel")]
            public string Rel { get; set; }

            [JsonProperty("href")]
            public string Href { get; set; }
        }

        public class Data
        {
            [JsonProperty("totalItems")]
            public long TotalItems { get; set; }

            [JsonProperty("kind")]
            public string Kind { get; set; }

            [JsonProperty("items")]
            public List<Item> Items { get; set; }

            [JsonProperty("item")]
            private Item Item
            {
                set
                {
                    Items = new List<Item>()
                    {
                        value
                    };

                    TotalItems = Items.Count;
                }
            }

            [JsonProperty("_links")]
            public List<Link> Links { get; set; }
        }

        public class PrinterCatalog
        {
            [JsonProperty("time")]
            public DateTime Time { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }
    }
}
