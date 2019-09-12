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
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool APPE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool ATLANTIC_FIERY_CODEBASE { get; set; }

            public string AUTOTRAPPING { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool AdvancedSchedulingForImpose { get; set; }

            public string Archive { get; set; }
            public string BOOKLETVERSION { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool BackupRestoreFonts { get; set; }

            public string CALIBRATION { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool COLOR_ICC_OUTPUTINTENT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool COLOR_ILSPROFILER { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool COLOR_MAINTENANCE_LP { get; set; }

            public string COMMON_LCD { get; set; }
            public string COMPOSE { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool COMPOSE1_FEATURE_SET { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool CORRECT_RASTER_INFO { get; set; }

            public string CWSDeviceCenterUseDryInkLevels { get; set; }
            public string ColorWise { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool ComposeLocalDongle { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool CustomImpose { get; set; }

            public string DBPRO { get; set; }
            public string DBPROVERSION { get; set; }
            public string DEFAULT_SERVER_PRESETS_VERSION { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool DISK_SYSTEM { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool DOCUMENT_CONVERSION { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool DOFONTARCHIVE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool DUAL_PROCESSOR { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool DocumentPagesPrinted { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool ECS_SUPPORT { get; set; }

            public string EFIBranding { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EFI_SLP { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EOZ2_CODEBASE { get; set; }

            public string EXPECTED_NUM_RIPS { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool EZRWS_CAPABLE { get; set; }

            public string EnableCancelWaitingToPrint { get; set; }
            public string ExtraStatusInfo { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool FIERY { get; set; }
            public string FIERY_PREFLIGHT { get; set; }
            public string FIERY_RASTER_PATH { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool FILE_SEARCH_PATH { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool FINER_TRAY_ALIGN_ADJUSTMENT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool FJDF_SUPPORT_FEATURES { get; set; }

            public string FJDF_SUPPORT_FEATURES_VERSION { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool FREEFORM { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA1_HALFTONE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA1_HOTFOLDER { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA1_ICCPROFILES { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA1_PAPERSIM { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA1_SOFTPROOF { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA1_SPOTON { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA1_SUBSTITUTECOLOR { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA1_TRAPPING { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_COMBINESEPS { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_COMPOVERPRINT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_COMPOVERPRINTWSPOT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_CONTROLSTRIP { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_DYNAMICSCREEN { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_FEATURE_SET { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_HALFTONE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_HOTFOLDERS { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_MULTICOLORMAP { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_OVERPRINT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_PAPERSIMEDIT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_POSTFLIGHT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_POSTFLIGHT_APPE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_RASTEREDIT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_SOFTPROOF { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_SPOTON2 { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_SUBSTITUTECOLOR { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_TRAPPING { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA2_USEPDFXPROFILE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GA_FEATURE_SET { get; set; }


            public string GMTimeZone { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool GRANULAR_BACKUP_RESTORE { get; set; }

            public string GreyImposeOverrides { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool HAS_DIRECT_QUEUE_FOR_FONT_DOWNLOAD { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool HEADED_SYSTEM { get; set; }

            public string HFPrintQueueAcceptsJobProperties { get; set; }
            public string HOTFOLDER { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool HOT_FOLDER_PDF1_6_FILTER { get; set; }

            public string HOW_TO { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool IFAX { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool IMAGEVIEWER_CURVES { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool IMAGEVIEWER_OBJECT_INSPECTOR { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool IMAGEWISE { get; set; }

            public string IMPOSEVERSION { get; set; }
            public string IMPOSE_FEATURE_180_SLOT_ROTATION { get; set; }
            public string IMPOSE_FEATURE_SLITMERGE { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool IMPOSE_HOT_FOLDER_CUSTOM_IMPOSITION { get; set; }

            public string IMPOSE_IMPROVED_PRESCIENT_DETECTION { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool INTENT_TICKETING { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool IPSEC { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool IPV6 { get; set; }

            public string Imposition { get; set; }
            public string ImpositionWD { get; set; }
            public string JOB_ERROR_REPORT_SUPPORT { get; set; }
            public string JOB_ESTIMATION { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool JOB_PARALLEL_RUSHRIP { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool JOB_PRESET { get; set; }

            public string JobLogMMInfo { get; set; }
            public string JobMasterTabVersion { get; set; }
            public string JobOverrides { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool JobParallel { get; set; }

            public string JobReorder { get; set; }
            public string JobReorderOrderColumn { get; set; }
            public string LCDPages { get; set; }
            public string MAXCOPIES { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool MEDIA_THUMBDRIVE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool MULTIRIP { get; set; }

            public string ManualDuplex { get; set; }
            public string MediaServer { get; set; }
            public string MixedMediaOn { get; set; }
            public string NCOLORVERSION { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool NETWORK_FTP_PASSIVE_MODE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool NETWORK_MAIL_ENHANCED_OPTIONS { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool NETWORK_PORTFILTER_HTTPSSLOFF { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool NETWORK_PORT_FILTERING { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool NETWORK_SNMP_COMMUNITYNAME_SETTINGS { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool NON_FIERY_CALIBRATION { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool NoVDPImposeUI_ForFF1 { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PC_BACKUPRESTORE_UI_ENABLE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PC_ColorProfile { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PC_FLOATING_POINT_DIMENSION { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PC_MM_SELECTIVE_DISABLE { get; set; }

            public string PC_PAPER_CATALOG_FEATURE { get; set; }
            public string PDF_VT { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PORT_9100 { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool POSTSCRIPT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PPD_NO_CONVERSION { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PPML { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PREFLIGHT_HF_AND_VP { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRINTER_CONTROL_LANGUAGE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRINT_AND_DELETE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_CANCEL_ON_MISMATCH { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_FEATURE_SET { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_HOTFOLDER { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_JOB_REORDER { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_JOB_REORDER_PRINTNEXT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_JOB_REORDER_PROCESSNEXT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_MM_PREVIEWS { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_PAPER_CATALOG { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_RUSH_JOB { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_SAMPLE_PRINT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_SCHEDULE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_SUSPEND_ON_MISMATCH { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PRODUCTION1_TABS { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PROOF_PRINT_ENABLED { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool Preflight { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PrintNext { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PrintRush { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool PrintSchedule { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool ProcessNext { get; set; }

            public string QDB { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool REMOTE_DESKTOP { get; set; }

            public string RIP_PROGRESS_USE_PAGES { get; set; }
            public string SCAN_ENABLED { get; set; }
            public string SECURE_DESKTOP { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SECURE_ERASE { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SECURITY1_FEATURE_SET { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SECURITY1_SAFE_ERASE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SECURITY1_SAFE_ERASE_V2 { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SENDJOBLOG { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SNTP { get; set; }

            public string SOFTWARE_LICENSING { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SPD_MAPPING { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SPOOL_PREVIEW_SUPPORTED { get; set; }

            public string SPOTON_JP_WORKFLOW { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SYSTEMUPDATE_SUPPORT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("Server generated thumbnails")]
            public bool ServerGeneratedThumbnails { get; set; }
        
            public string SoftProof { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SuspendOnMismatch { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SuspendOnMismatchV2 { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool SuspendResume { get; set; }

            public string TBICON_DisplayPaperCatalog { get; set; }
            public string TBICON_StartStop { get; set; }
            public string TBICON_Warnings { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool TROY_CODEBASE { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool TabsPrintingOn { get; set; }

            public string TrayAlignment { get; set; }
            public string TrayAlignmentTestPage { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool USER_AUTHENTICATION { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool USER_AUTHENTICATION_ADMIN { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool USER_AUTHENTICATION_SCAN_TIME_USERS { get; set; }

            public string UTF8_VERSION { get; set; }
            public string VDPImpose { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool VDP_IMPOSITION { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool VIPP { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool VIRTUAL_PRINTERS { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool VPS { get; set; }

            public string VirtualPrinter { get; set; }
            public string VirtualPrinterMaximumNumberOfPrinters { get; set; }
            public string WEBTOOLS_VERSION { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool XEROX_MOBILE_PRINT { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool XER_FREEFLOW { get; set; }
            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            public bool XPS { get; set; }

            [JsonProperty("clear_coat/n_color")]
            public string ClearCoatColor { get; set; }

            [JsonProperty("cws setup device type")]
            public string CwsSetupDeviceType { get; set; }

            [JsonProperty("cws setup key")]
            public string CwsSetupKey { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("debug build")]
            public bool DebugBuild { get; set; }

            [JsonProperty("harmony lib version")]
            public string HarmonyLibVersion { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("held job reordering")]
            public bool HeldJobReordering { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("job reordering")]
            public bool JobReordering { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("not activated")]
            public bool NotActivated { get; set; }

            [JsonProperty("operating system")]
            public string OperatingSystem { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("pcl support")]
            public bool PCLSupport { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("pdf support")]
            public bool PDFSupport { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("postscript support")]
            public bool PostScriptSupport { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("ppml support")]
            public bool PPMLSupport { get; set; }

            [JsonProperty("product family")]
            public string ProductFamily { get; set; }

            [JsonProperty("progress indicator")]
            public string ProgressIndicator { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("racing smart rip")]
            public bool RacingSmartRip { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("rip and hold generates new job")]
            public bool RipAndHoldGeneratesNewJob { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("rip while receive")]
            public bool RipWhileReceive { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("scan to print")]
            public bool ScanToPrint { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("thumbnails on demand")]
            public bool ThumbnailsOnDemand { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("tiff support")]
            public bool TIFFSupport { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("vipp support")]
            public bool VIPPSupport { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("vpc support")]
            public bool VPCSupport { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("vps support")]
            public bool VPSSupport { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("waiting to print job reordering")]
            public bool WaitingToPrintJobReordering { get; set; }

            [JsonConverter(typeof(FieryHelpers.BooleanConverter))]
            [JsonProperty("waiting to rip job reordering")]
            public bool WaitingToRipJobReordering { get; set; }
        }
    }
}
