using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFI_Fiery_API
{
    public class FieryFeatures
    {
        public class PrinterFeatures
        {
            [JsonProperty("time")]
            public DateTimeOffset DateTime { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }

        public partial class Link
        {
            [JsonProperty("rel")]
            public string Rel { get; set; }

            [JsonProperty("href")]
            public Uri Href { get; set; }
        }

        public class Data
        {
            [JsonProperty("kind")]
            public string kind { get; set; }

            [JsonProperty("item")]
            public Item Item { get; set; }

            [JsonProperty("_links")]
            public List<Link> Links { get; set; }
        }

        public class Item
        {
            public string APPE { get; set; }
            public string ATLANTIC_FIERY_CODEBASE { get; set; }
            public string AUTOTRAPPING { get; set; }
            public string AdvancedSchedulingForImpose { get; set; }
            public string Archive { get; set; }
            public string BOOKLETVERSION { get; set; }
            public string BackupRestoreFonts { get; set; }
            public string CALIBRATION { get; set; }
            public string COLOR_ICC_OUTPUTINTENT { get; set; }
            public string COLOR_ILSPROFILER { get; set; }
            public string COLOR_MAINTENANCE_LP { get; set; }
            public string COMMON_LCD { get; set; }
            public string COMPOSE { get; set; }
            public string COMPOSE1_FEATURE_SET { get; set; }
            public string CORRECT_RASTER_INFO { get; set; }
            public string CWSDeviceCenterUseDryInkLevels { get; set; }
            public string ColorWise { get; set; }
            public string ComposeLocalDongle { get; set; }
            public string CustomImpose { get; set; }
            public string DBPRO { get; set; }
            public string DBPROVERSION { get; set; }
            public string DEFAULT_SERVER_PRESETS_VERSION { get; set; }
            public string DISK_SYSTEM { get; set; }
            public string DOCUMENT_CONVERSION { get; set; }
            public string DOFONTARCHIVE { get; set; }
            public string DUAL_PROCESSOR { get; set; }
            public string DocumentPagesPrinted { get; set; }
            public string ECS_SUPPORT { get; set; }
            public string EFIBranding { get; set; }
            public string EFI_SLP { get; set; }
            public string EOZ2_CODEBASE { get; set; }
            public string EXPECTED_NUM_RIPS { get; set; }
            public string EZRWS_CAPABLE { get; set; }
            public string EnableCancelWaitingToPrint { get; set; }
            public string ExtraStatusInfo { get; set; }
            public string FIERY { get; set; }
            public string FIERY_PREFLIGHT { get; set; }
            public string FIERY_RASTER_PATH { get; set; }
            public string FILE_SEARCH_PATH { get; set; }
            public string FINER_TRAY_ALIGN_ADJUSTMENT { get; set; }
            public string FJDF_SUPPORT_FEATURES { get; set; }
            public string FJDF_SUPPORT_FEATURES_VERSION { get; set; }
            public string FREEFORM { get; set; }
            public string GA1_HALFTONE { get; set; }
            public string GA1_HOTFOLDER { get; set; }
            public string GA1_ICCPROFILES { get; set; }
            public string GA1_PAPERSIM { get; set; }
            public string GA1_SOFTPROOF { get; set; }
            public string GA1_SPOTON { get; set; }
            public string GA1_SUBSTITUTECOLOR { get; set; }
            public string GA1_TRAPPING { get; set; }
            public string GA2_COMBINESEPS { get; set; }
            public string GA2_COMPOVERPRINT { get; set; }
            public string GA2_COMPOVERPRINTWSPOT { get; set; }
            public string GA2_CONTROLSTRIP { get; set; }
            public string GA2_DYNAMICSCREEN { get; set; }
            public string GA2_FEATURE_SET { get; set; }
            public string GA2_HALFTONE { get; set; }
            public string GA2_HOTFOLDERS { get; set; }
            public string GA2_MULTICOLORMAP { get; set; }
            public string GA2_OVERPRINT { get; set; }
            public string GA2_PAPERSIMEDIT { get; set; }
            public string GA2_POSTFLIGHT { get; set; }
            public string GA2_POSTFLIGHT_APPE { get; set; }
            public string GA2_RASTEREDIT { get; set; }
            public string GA2_SOFTPROOF { get; set; }
            public string GA2_SPOTON2 { get; set; }
            public string GA2_SUBSTITUTECOLOR { get; set; }
            public string GA2_TRAPPING { get; set; }
            public string GA2_USEPDFXPROFILE { get; set; }
            public string GA_FEATURE_SET { get; set; }
            public string GMTimeZone { get; set; }
            public string GRANULAR_BACKUP_RESTORE { get; set; }
            public string GreyImposeOverrides { get; set; }
            public string HAS_DIRECT_QUEUE_FOR_FONT_DOWNLOAD { get; set; }
            public string HEADED_SYSTEM { get; set; }
            public string HFPrintQueueAcceptsJobProperties { get; set; }
            public string HOTFOLDER { get; set; }
            public string HOT_FOLDER_PDF1_6_FILTER { get; set; }
            public string HOW_TO { get; set; }
            public string IFAX { get; set; }
            public string IMAGEVIEWER_CURVES { get; set; }
            public string IMAGEVIEWER_OBJECT_INSPECTOR { get; set; }
            public string IMAGEWISE { get; set; }
            public string IMPOSEVERSION { get; set; }
            public string IMPOSE_FEATURE_180_SLOT_ROTATION { get; set; }
            public string IMPOSE_FEATURE_SLITMERGE { get; set; }
            public string IMPOSE_HOT_FOLDER_CUSTOM_IMPOSITION { get; set; }
            public string IMPOSE_IMPROVED_PRESCIENT_DETECTION { get; set; }
            public string INTENT_TICKETING { get; set; }
            public string IPSEC { get; set; }
            public string IPV6 { get; set; }
            public string Imposition { get; set; }
            public string ImpositionWD { get; set; }
            public string JOB_ERROR_REPORT_SUPPORT { get; set; }
            public string JOB_ESTIMATION { get; set; }
            public string JOB_PARALLEL_RUSHRIP { get; set; }
            public string JOB_PRESET { get; set; }
            public string JobLogMMInfo { get; set; }
            public string JobMasterTabVersion { get; set; }
            public string JobOverrides { get; set; }
            public string JobParallel { get; set; }
            public string JobReorder { get; set; }
            public string JobReorderOrderColumn { get; set; }
            public string LCDPages { get; set; }
            public string MAXCOPIES { get; set; }
            public string MEDIA_THUMBDRIVE { get; set; }
            public string MULTIRIP { get; set; }
            public string ManualDuplex { get; set; }
            public string MediaServer { get; set; }
            public string MixedMediaOn { get; set; }
            public string NCOLORVERSION { get; set; }
            public string NETWORK_FTP_PASSIVE_MODE { get; set; }
            public string NETWORK_MAIL_ENHANCED_OPTIONS { get; set; }
            public string NETWORK_PORTFILTER_HTTPSSLOFF { get; set; }
            public string NETWORK_PORT_FILTERING { get; set; }
            public string NETWORK_SNMP_COMMUNITYNAME_SETTINGS { get; set; }
            public string NON_FIERY_CALIBRATION { get; set; }
            public string NoVDPImposeUI_ForFF1 { get; set; }
            public string PC_BACKUPRESTORE_UI_ENABLE { get; set; }
            public string PC_ColorProfile { get; set; }
            public string PC_FLOATING_POINT_DIMENSION { get; set; }
            public string PC_MM_SELECTIVE_DISABLE { get; set; }
            public string PC_PAPER_CATALOG_FEATURE { get; set; }
            public string PDF_VT { get; set; }
            public string PORT_9100 { get; set; }
            public string POSTSCRIPT { get; set; }
            public string PPD_NO_CONVERSION { get; set; }
            public string PPML { get; set; }
            public string PREFLIGHT_HF_AND_VP { get; set; }
            public string PRINTER_CONTROL_LANGUAGE { get; set; }
            public string PRINT_AND_DELETE { get; set; }
            public string PRODUCTION1_CANCEL_ON_MISMATCH { get; set; }
            public string PRODUCTION1_FEATURE_SET { get; set; }
            public string PRODUCTION1_HOTFOLDER { get; set; }
            public string PRODUCTION1_JOB_REORDER { get; set; }
            public string PRODUCTION1_JOB_REORDER_PRINTNEXT { get; set; }
            public string PRODUCTION1_JOB_REORDER_PROCESSNEXT { get; set; }
            public string PRODUCTION1_MM_PREVIEWS { get; set; }
            public string PRODUCTION1_PAPER_CATALOG { get; set; }
            public string PRODUCTION1_RUSH_JOB { get; set; }
            public string PRODUCTION1_SAMPLE_PRINT { get; set; }
            public string PRODUCTION1_SCHEDULE { get; set; }
            public string PRODUCTION1_SUSPEND_ON_MISMATCH { get; set; }
            public string PRODUCTION1_TABS { get; set; }
            public string PROOF_PRINT_ENABLED { get; set; }
            public string Preflight { get; set; }
            public string PrintNext { get; set; }
            public string PrintRush { get; set; }
            public string PrintSchedule { get; set; }
            public string ProcessNext { get; set; }
            public string QDB { get; set; }
            public string REMOTE_DESKTOP { get; set; }
            public string RIP_PROGRESS_USE_PAGES { get; set; }
            public string SCAN_ENABLED { get; set; }
            public string SECURE_DESKTOP { get; set; }
            public string SECURE_ERASE { get; set; }
            public string SECURITY1_FEATURE_SET { get; set; }
            public string SECURITY1_SAFE_ERASE { get; set; }
            public string SECURITY1_SAFE_ERASE_V2 { get; set; }
            public string SENDJOBLOG { get; set; }
            public string SNTP { get; set; }
            public string SOFTWARE_LICENSING { get; set; }
            public string SPD_MAPPING { get; set; }
            public string SPOOL_PREVIEW_SUPPORTED { get; set; }
            public string SPOTON_JP_WORKFLOW { get; set; }
            public string SYSTEMUPDATE_SUPPORT { get; set; }

            [JsonProperty("Server generated thumbnails")]
            public string ServerGeneratedThumbnails { get; set; }
        
            public string SoftProof { get; set; }
            public string SuspendOnMismatch { get; set; }
            public string SuspendOnMismatchV2 { get; set; }
            public string SuspendResume { get; set; }
            public string TBICON_DisplayPaperCatalog { get; set; }
            public string TBICON_StartStop { get; set; }
            public string TBICON_Warnings { get; set; }
            public string TROY_CODEBASE { get; set; }
            public string TabsPrintingOn { get; set; }
            public string TrayAlignment { get; set; }
            public string TrayAlignmentTestPage { get; set; }
            public string USER_AUTHENTICATION { get; set; }
            public string USER_AUTHENTICATION_ADMIN { get; set; }
            public string USER_AUTHENTICATION_SCAN_TIME_USERS { get; set; }
            public string UTF8_VERSION { get; set; }
            public string VDPImpose { get; set; }
            public string VDP_IMPOSITION { get; set; }
            public string VIPP { get; set; }
            public string VIRTUAL_PRINTERS { get; set; }
            public string VPS { get; set; }
            public string VirtualPrinter { get; set; }
            public string VirtualPrinterMaximumNumberOfPrinters { get; set; }
            public string WEBTOOLS_VERSION { get; set; }
            public string XEROX_MOBILE_PRINT { get; set; }
            public string XER_FREEFLOW { get; set; }
            public string XPS { get; set; }

            [JsonProperty("clear_coat/n_color")]
            public string ClearCoatColor { get; set; }

            [JsonProperty("cws setup device type")]
            public string CwsSetupDeviceType { get; set; }

            [JsonProperty("cws setup key")]
            public string CwsSetupKey { get; set; }

            [JsonProperty("debug build")]
            public string DebugBuild { get; set; }

            [JsonProperty("harmony lib version")]
            public string HarmonyLibVersion { get; set; }

            [JsonProperty("held job reordering")]
            public string HeldJobReordering { get; set; }

            [JsonProperty("job reordering")]
            public string JobReordering { get; set; }

            [JsonProperty("not activated")]
            public string NotActivated { get; set; }

            [JsonProperty("operating system")]
            public string OperatingSystem { get; set; }

            [JsonProperty("pcl support")]
            public string PCLSupport { get; set; }

            [JsonProperty("pdf support")]
            public string PDFSupport { get; set; }

            [JsonProperty("postscript support")]
            public string PostScriptSupport { get; set; }

            [JsonProperty("ppml support")]
            public string PPMLSupport { get; set; }

            [JsonProperty("product family")]
            public string ProductFamily { get; set; }

            [JsonProperty("progress indicator")]
            public string ProgressIndicator { get; set; }

            [JsonProperty("racing smart rip")]
            public string RacingSmartRip { get; set; }

            [JsonProperty("rip and hold generates new job")]
            public string RipAndHoldGeneratesNewJob { get; set; }

            [JsonProperty("rip while receive")]
            public string RipWhileReceive { get; set; }

            [JsonProperty("scan to print")]
            public string ScanToPrint { get; set; }

            [JsonProperty("thumbnails on demand")]
            public string ThumbnailsOnDemand { get; set; }

            [JsonProperty("tiff support")]
            public string TIFFSupport { get; set; }

            [JsonProperty("vipp support")]
            public string VIPPSupport { get; set; }

            [JsonProperty("vpc support")]
            public string VPCSupport { get; set; }

            [JsonProperty("vps support")]
            public string VPSSupport { get; set; }

            [JsonProperty("waiting to print job reordering")]
            public string WaitingToPrintJobReordering { get; set; }

            [JsonProperty("waiting to rip job reordering")]
            public string WaitingToRipJobReordering { get; set; }
        }
    }
}
