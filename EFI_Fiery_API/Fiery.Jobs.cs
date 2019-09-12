using Newtonsoft.Json;
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

        public enum PreviewState
        {
            Thumb,
            Screen,
            Full
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

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("date")]
            public DateTime Date { get; set; } 

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

            [JsonProperty("has disk raster?")]
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

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            public DateTime EFIPrintTime { get; set; }

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

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EFPadPrinting { get; set; }


            public string EFPageDelivery { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EFPCPadCover { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EFPostFlight { get; set; }

            public string EFPrintCover { get; set; }

            public string EFPrintSize { get; set; }
            public long EFSheetsInPad { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EFSlipsheet { get; set; }

            public long EFSlipSheetFreq { get; set; }
            public string EFSort { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EFUseAPPE { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EFUserRotate180 { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EFUseSPDMediaMapping { get; set; }

            public string PageSize { get; set; }
            public long EFPCMID { get; set; }
            public string EFPCName { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp created")]
            public DateTime TimestampCreated { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp done printing")]
            public DateTime TimestampDonePrinting { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp done ripping")]
            public DateTime TimestampDoneRipping { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp done spooling")]
            public DateTime TimestampDoneSpooling { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 0")]
            public DateTime TimestampDQProgress0 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 1")]
            public DateTime TimestampDQProgress1 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 10")]
            public DateTime TimestampDQProgress10 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 2")]
            public DateTime TimestampDQProgress2 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 3")]
            public DateTime TimestampDQProgress3 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 4")]
            public DateTime TimestampDQProgress4 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 5")]
            public DateTime TimestampDQProgress5 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 6")]
            public DateTime TimestampDQProgress6 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 7")]
            public DateTime TimestampDQProgress7 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 8")]
            public DateTime TimestampDQProgress8 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 9")]
            public DateTime TimestampDQProgress9 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 97")]
            public DateTime TimestampDQProgress97 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 98")]
            public DateTime TimestampDQProgress98 { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp final LOG event")]
            public DateTime TimestampFinalLogEvent { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp final video page event")]
            public DateTime TimestampFinalVideoPageEvent { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp first data")]
            public DateTime TimestampFirstData { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp joblog")]
            public DateTime TimestampJobLog { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp first page printed")]
            public DateTime TimestampFirstPagePrinted { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp last page ripped")]
            public DateTime TimestampLagePageRipped { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp printing")]
            public DateTime TimestampPrinting { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp ripping")]
            public DateTime TimestampRipping { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp spooling")]
            public DateTime TimestampSpooling { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp touched")]
            public DateTime TimestampTouched { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp waiting to print")]
            public DateTime TimestampWaitingToPrint { get; set; }

            [JsonConverter(typeof(EFI_Fiery_API.FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp waiting to rip")]
            public DateTime TimestampWaitingToRip { get; set; }

            [JsonProperty("EFColorant1_RangeType")]
            public string EFColourAnt1RangeType { get; set; }

            [JsonProperty("EFColorant1_RangeValue")]
            public string EFColourAnt1RangeValue { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("EFImageWiseRange")]
            public bool EFImageWiseRange { get; set; }

            [JsonProperty("EFImageWise_RangeType")]
            public string EFImageWiseRangeType { get; set; }

            [JsonProperty("EFImageWise_RangeValue")]
            public string EFImageWiseRangeValue { get; set; }
            public string EFInpPrintRange { get; set; }
            public string EFOutPrintRange { get; set; }
        }
    }
}
