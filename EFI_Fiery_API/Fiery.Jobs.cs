using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryJobs
    {
        public enum JobState
        {
            Error = 0,
            Held,
            Processed,
            Spooled,
            Printed,
            WaitingToProcess,
            WaitingToPrint,
            Printing,
            Processing,
            Archived
        }

        public partial class PrinterJobs
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
            public List<Item> Items { get; set; }

            [JsonProperty("_links")]
            public List<Link> Links { get; set; }
        }

        public partial class Link
        {
            [JsonProperty("rel")]
            public string Rel { get; set; }

            [JsonProperty("href")]
            public Uri Href { get; set; }
        }

        public class Item
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }
            
            [JsonProperty("username")]
            public string Username { get; set; }
            
            [JsonProperty("status")]
            public string Status { get; set; }
            
            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("print status")]
            public string PrintStatus { get; set; }

            [JsonProperty("date")]
            public DateTimeOffset Date { get; set; } 

            [JsonProperty("num pages")]
            public string NumberofPages { get; set; }

            [JsonProperty("size")]
            public long FileSize { get; set; }

            [JsonProperty("media type")]
            public string MediaType { get; set; }

            [JsonProperty("media size")]
            public string MediaSize { get; set; }

            [JsonProperty("media weight")]
            public string MediaWeight { get; set; }

            [JsonProperty("input slot")]
            public string InputSlot { get; set; }

            [JsonProperty("total pages printed")]
            public long TotalPagesPrinted { get; set; }

            [JsonProperty("total sheets printed")]
            public long TotalSheetsPrinted { get; set; }

            [JsonProperty("total bw pages printed")]
            public long TotalBWPagesPrinted { get; set; }

            [JsonProperty("total color pages printed")]
            public long TotalColourPagesPrinted { get; set; }

            [JsonProperty("copies printed")]
            public long CopiesPrinted { get; set; }

            [JsonProperty("total tab pages printed")]
            public long TotalTabPagesPrinted { get; set; }

            [JsonProperty("total blank pages printed")]
            public long TotalBlankPagesPrinted { get; set; }
            
            [JsonProperty("total ejected tab pages printed")]
            public long TotalEjectedTabPagesPrinted { get; set; }

            [JsonProperty("instructions")]
            public string Instructions { get; set; }

            [JsonProperty("notes1")]
            public string Notes1 { get; set; }

            [JsonProperty("notes2")]
            public string Notes2 { get; set; }

            [JsonProperty("fiery")]
            public string Fiery { get; set; }

            [JsonProperty("duplex printed")]
            public string DuplexPrinted { get; set; }

            [JsonProperty("authuser")]
            public string AuthorizedUser { get; set; }

            [JsonProperty("held?")]
            public string IsHeld { get; set; }

            [JsonProperty("has disk raster")]
            public string HasDiskRaster { get; set; }

            [JsonProperty("Notes1")]
            public string Notes3 { get; set; }

            [JsonProperty("Notes2")]
            public string Notes4 { get; set; }

            [JsonProperty("original job ID")]
            public string OriginalJobID { get; set; }

            [JsonProperty("logical printer")]
            public string LogicalPrinter { get; set; }

            public string EFDuplex { get; set; }

            public DateTimeOffset EFIPrintTime { get; set; }

            public string Instruct { get; set; }
            public string EFRaster { get; set; }
            public string EFPageRange { get; set; }

            [JsonProperty("num copies")]
            public long NumberofCopies { get; set; }


            public string EFAutoScaling { get; set; }
            public decimal EFBrightness { get; set; }

            [JsonProperty("EFColorMode")]
            public string EFColourMode { get; set; }

            public string EFControlBar { get; set; }
            public string EFDFAProfile { get; set; }
            public string EFImageAlign { get; set; }
            public long EFImageBackX { get; set; }
            public long EFImageBackY { get; set; }
            public string EFImageFlag { get; set; }
            public long EFImageFrontX { get; set; }
            public long EFImageFrontY { get; set; }
            public string EFImageUnit { get; set; }
            public string EFMediaCoatSide { get; set; }
            public string EFMediaCoatType { get; set; }

            [JsonProperty("EFMediaColor")]
            public string EFMediaColour { get; set; }

            public long EFMediaCount { get; set; }
            public string EFMediaFinish { get; set; }
            public string EFMediaHoleType { get; set; }
            public string EFMediaType { get; set; }
            public string EFMediaWeight { get; set; }
            public string EFOutputBin { get; set; }
            public bool EFPadPrinting { get; set; }
            public string EFPageDelivery { get; set; }
            public bool EFPCPadCover { get; set; }
            public bool EFPostFlight { get; set; }
            public bool EFPrintCover { get; set; }
            public string EFPrintSize { get; set; }
            public long EFSheetsInPad { get; set; }
            public bool EFSlipsheet { get; set; }
            public long EFSlipSheetFreq { get; set; }
            public string EFSort { get; set; }
            public bool EFUseAPPE { get; set; }
            public bool EFUserRotate180 { get; set; }
            public bool EFUseSPDMediaMapping { get; set; }
            public string PageSize { get; set; }
            public long EFPCMID { get; set; }
            public string EFPCName { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp created")]
            public DateTimeOffset TimestampCreated { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp done printing")]
            public DateTimeOffset TimestampDonePrinting { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp done ripping")]
            public DateTimeOffset TimestampDoneRipping { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp done spooling")]
            public DateTimeOffset TimestampDoneSpooling { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 0")]
            public DateTimeOffset TimestampDQProgress0 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 1")]
            public DateTimeOffset TimestampDQProgress1 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 10")]
            public DateTimeOffset TimestampDQProgress10 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 2")]
            public DateTimeOffset TimestampDQProgress2 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 3")]
            public DateTimeOffset TimestampDQProgress3 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 4")]
            public DateTimeOffset TimestampDQProgress4 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 5")]
            public DateTimeOffset TimestampDQProgress5 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 6")]
            public DateTimeOffset TimestampDQProgress6 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 7")]
            public DateTimeOffset TimestampDQProgress7 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 8")]
            public DateTimeOffset TimestampDQProgress8 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 9")]
            public DateTimeOffset TimestampDQProgress9 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 97")]
            public DateTimeOffset TimestampDQProgress97 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 98")]
            public DateTimeOffset TimestampDQProgress98 { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp final LOG event")]
            public DateTimeOffset TimestampFinalLogEvent { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp final video page event")]
            public DateTimeOffset TimestampFinalVideoPageEvent { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp first data")]
            public DateTimeOffset TimestampFirstData { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp joblog")]
            public DateTimeOffset TimestampJobLog { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp first page printed")]
            public DateTimeOffset TimestampFirstPagePrinted { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp last page ripped")]
            public DateTimeOffset TimestampLagePageRipped { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp first page printed")]
            public DateTimeOffset TeimstampFirstPagePrinted { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp printing")]
            public DateTimeOffset TimestampPrinting { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp ripping")]
            public DateTimeOffset TimestampRipping { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp spooling")]
            public DateTimeOffset TimestampSpooling { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp touched")]
            public DateTimeOffset TimestampTouched { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp waiting to print")]
            public DateTimeOffset TimestampWaitingToPrint { get; set; }

            [JsonConverter(typeof(UnixDateTimeConverter))]
            [JsonProperty("timestamp waiting to rip")]
            public DateTimeOffset TimestampWaitingToRip { get; set; }

            [JsonProperty("EFColorant1_RangeType")]
            public string EFColourAnt1RangeType { get; set; }

            [JsonProperty("EFColorant1_RangeValue")]
            public string EFColourAnt1RangeValue { get; set; }

            [JsonProperty("EFImageWiseRange")]
            public bool EFImageWiseRange { get; set; }

            [JsonProperty("EFIImageWise_RangeType")]
            public string EFImageWiseRangeType { get; set; }

            [JsonProperty("EFImageWise_RangeValue")]
            public string EFImageWiseRangeValue { get; set; }
            public string EFInpPrintRange { get; set; }
            public string EFOutPrintRange { get; set; }
        }
    }
}
