using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryPrinterAccounting
    {
        public class PrinterJobAccounting
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

            [JsonProperty("job_id")]
            public string JobId { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("print status")]
            public string PrintStatus { get; set; }

            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("num pages")]
            public long NumPages { get; set; }

            [JsonConverter(typeof(FieryHelpers.KbToMbConverter))]
            [JsonProperty("size")]
            public string Size { get; set; }

            [JsonProperty("total pages printed")]
            public long TotalPagesPrinted { get; set; }

            [JsonProperty("total sheets printed")]
            public long TotalSheetsPrinted { get; set; }

            [JsonProperty("total bw pages printed")]
            public long TotalBwPagesPrinted { get; set; }

            [JsonProperty("total color pages printed")]
            public long TotalColorPagesPrinted { get; set; }

            [JsonProperty("copies printed")]
            public long CopiesPrinted { get; set; }

            [JsonProperty("total tab pages printed")]
            public long TotalTabPagesPrinted { get; set; }

            [JsonProperty("total blank pages printed")]
            public long TotalBlankPagesPrinted { get; set; }

            [JsonProperty("total ejected tab pages printed")]
            public long TotalEjectedTabPagesPrinted { get; set; }

            [JsonProperty("fiery")]
            public string Fiery { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("duplex printed")]
            public bool DuplexPrinted { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp done printing")]
            public DateTime TimestampDonePrinting { get; set; }

            [JsonProperty("authuser")]
            public string Authuser { get; set; }

            [JsonProperty("print destination")]
            public string PrintDestination { get; set; }

            [JsonProperty("timestamp canceled", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            public DateTime TimestampCanceled { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp created")]
            public DateTime TimestampCreated { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp done ripping")]
            public DateTime TimestampDoneRipping { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp done spooling")]
            public DateTime TimestampDoneSpooling { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp final LOG event")]
            public DateTime TimestampFinalLogEvent { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp final video page event")]
            public DateTime TimestampFinalVideoPageEvent { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp first data")]
            public DateTime TimestampFirstData { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp joblog")]
            public DateTime TimestampJoblog { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp last page ripped")]
            public DateTime TimestampLastPageRipped { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp pdl error", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampPdlError { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp printing")]
            public DateTime TimestampPrinting { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp ripping")]
            public DateTime TimestampRipping { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp spooling")]
            public DateTime TimestampSpooling { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp waiting to print")]
            public DateTime TimestampWaitingToPrint { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp waiting to rip")]
            public DateTime TimestampWaitingToRip { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 0", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress0 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 1", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress1 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 10", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress10 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 2", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress2 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 3", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress3 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 4", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress4 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 5", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress5 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 6", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress6 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 7", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress7 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 8", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress8 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 9", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress9 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 97", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress97 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp dq progress 98", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampDqProgress98 { get; set; }

            [JsonConverter(typeof(FieryHelpers.UnixDateTimeConverter))]
            [JsonProperty("timestamp touched", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime TimestampTouched { get; set; }
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
