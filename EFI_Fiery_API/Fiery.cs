using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EbbsSoft.ExtensionHelpers.T_Helpers;
using System.Net;
using EbbsSoft.ExtensionHelpers.DoubleHelpers;
using EbbsSoft.ExtensionHelpers.DateTimeHelpers;

namespace EFI
{
    public partial class Fiery
    {
        private Fiery()
        {
        }

        /// <summary>
        /// Media Type For Rest Requests.
        /// </summary>
        private const string MEDIA_TYPE = "application/json";

        /// <summary>
        /// 
        /// </summary>
        public static readonly Lazy<bool> IsCertificateValidationApplied = new Lazy<bool>(ApplyServerCertificateValidation, true);

        /// <summary>
        /// 
        /// </summary>
        private object LockAsync { get; set; }

        /// <summary>
        /// https://developer.efi.com/
        /// </summary>
        /// <value></value>
        public static string AccessKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private static Cookie SessionIDCookie { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static bool ApplyServerCertificateValidation()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            return true;
        }

        /// <summary>
        /// Printer.
        /// </summary>
        public class Printer
        {
            /// <summary>
            /// 
            /// </summary>
            /// <value></value>
            public string IPAddress {get;set;}
            
            /// <summary>
            /// 
            /// </summary>
            /// <param name="ipAddress"></param>
            public Printer(string ipAddress)
            {
                // Check if the ip address is valid.
                if (IsValidIPAddress(ipAddress))
                {
                    this.IPAddress = ipAddress;
                }
                else
                {
                    throw new Exception("IP Address Not Valid");
                }
            }

            /// <summary>
            /// 
            /// </summary>
            public Printer(){}

            /// <summary>
            /// Valid IP Address.
            /// </summary>
            /// <param name="ipAddress"></param>
            /// <returns></returns>
            private bool IsValidIPAddress(string ipAddress)
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(ipAddress);
                return ip.ToString() == ipAddress;
            }
        }

        /// <summary>
        /// Establishes authorized user access to the Fiery API features
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryLogin.Login Login(Printer printer, string username, string password)
        {
            // Apply Certificate.
            Console.Write("{0}", IsCertificateValidationApplied.Value ? "Certificate Applied" : "Certificate Was Unable To Be Applied");

            if (printer == null)
            {
                throw new ArgumentNullException(nameof(printer));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("message", nameof(username));
            }

            EFI_Fiery_API.FieryLogin.Login loginResponse = SendLoginRequest(printer, username, password).Result;

            return loginResponse;
        }

        /// <summary>
        /// Terminates an authorized session initialized by the "login" request
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static bool Logout(Printer printer)
        {
            bool isLoggedOut = false;
            Task task = Task.Run(async () =>
            {
                string url = $"https://{printer.IPAddress}/live/api/v4/logout";
                using (HttpClient httpClient = new HttpClient())
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url))
                {
                    HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        SessionIDCookie = null;
                    }

                    isLoggedOut = httpResponseMessage.IsSuccessStatusCode;
                }
            });
            Task.WaitAll(task);
            return isLoggedOut;
        }

        /// <summary>
        /// Returns Fiery's basic info, such as "name", "version", "disk_available", etc
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryPrinterInformation.PrinterInformation PrinterInformation(Printer printer) => 
            SendGetRequest<EFI_Fiery_API.FieryPrinterInformation.PrinterInformation>(printer, $"https://{printer.IPAddress}/live/api/v4/info");

        /// <summary>
        /// Reports a string value indicating the current status of the Fiery software
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryPrinterStatus.PrinterStatus PrinterStatus(Printer printer) => 
            SendGetRequest<EFI_Fiery_API.FieryPrinterStatus.PrinterStatus>(printer, $"https://{printer.IPAddress}/live/api/v4/status");

        /// <summary>
        /// Requests information about the Fiery (as returned #by "java.util.TimeZone.getAvailableIDs()". .
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryPrinterDetail.PrinterDetail PrinterDetail(Printer printer) => 
            SendGetRequest<EFI_Fiery_API.FieryPrinterDetail.PrinterDetail>(printer, $"https://{printer.IPAddress}/live/api/v4/info/detail");

        /// <summary>
        /// Reports information about the supply of paper, tray, and toner on the print engine.
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryComsumables.PrinterComsumables PrinterComsumables(Printer printer) => 
            SendGetRequest<EFI_Fiery_API.FieryComsumables.PrinterComsumables>(printer, $"https://{printer.IPAddress}/live/api/v4/consumables");

        /// <summary>
        /// Return Fiery's Support Feature options/keys
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryFeatures.PrinterFeatures PrinterFeatures(Printer printer) =>
            SendGetRequest<EFI_Fiery_API.FieryFeatures.PrinterFeatures>(printer, $"https://{printer.IPAddress}/live/api/v4/features");

        /// <summary>
        /// Lists printable system pages which can be output.
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryPrintPages.PrinterPrintPages PrinterPrintPages(Printer printer) =>
            SendGetRequest<EFI_Fiery_API.FieryPrintPages.PrinterPrintPages>(printer, $"https://{printer.IPAddress}/live/api/v4/printpages");

        /// <summary>
        /// Reports a string value indicating the current status of the Fiery software
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryServer.PrinterServerStatus PrinterServerStatus(Printer printer) =>
            SendGetRequest<EFI_Fiery_API.FieryServer.PrinterServerStatus>(printer, $"https://{printer.IPAddress}/live/api/v4/server/status");

        /// <summary>
        /// Returns information about the print device connected to the Fiery server and its currently printing/ripping jobs' progress.
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryDevices.PrinterDevices PrinterDevices(Printer printer) =>
            SendGetRequest<EFI_Fiery_API.FieryDevices.PrinterDevices>(printer, $"https://{printer.IPAddress}/live/api/v4/devices");

        /// <summary>
        /// Lists jobs in all queues on Fiery and their attributes
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryJobs.PrinterJobs PrinterJobs(Printer printer) =>
            SendGetRequest<EFI_Fiery_API.FieryJobs.PrinterJobs>(printer, $"https://{printer.IPAddress}/live/api/v4/jobs");

        /// <summary>
        /// Returns job attributes of a job specified by id
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="jobId"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryJobs.PrinterJobs PrinterJobs(Printer printer, string jobId) =>
            SendGetRequest<EFI_Fiery_API.FieryJobs.PrinterJobs>(printer, $"https://{printer.IPAddress}/live/api/v4/jobs/{jobId}");

        /// <summary>
        /// Retrieve jobs base on job states
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="jobId"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryJobs.PrinterJobs PrinterJobs(Printer printer, EFI_Fiery_API.FieryJobs.JobState jobState) =>
            SendGetRequest<EFI_Fiery_API.FieryJobs.PrinterJobs>(printer, $"https://{printer.IPAddress}/live/api/v4/jobs/{jobState.ToString()}");

        /// <summary>
        /// Retrieve preview of the job
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="jobId"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryPrinterJobPreview PrinterJobsPreview(Printer printer, string jobId, int pageNumber) =>
            SendGetRequest<EFI_Fiery_API.FieryPrinterJobPreview>(printer, $"https://{printer.IPAddress}/live/api/v4/jobs/{jobId}/preview/{pageNumber}");

        /// <summary>
        /// Retrieve preview of the job
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="jobId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="previewState"></param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryPrinterJobPreview PrinterJobsPreview(Printer printer, string jobId, int pageNumber, EFI_Fiery_API.FieryJobs.PreviewState previewState) =>
            SendGetRequest<EFI_Fiery_API.FieryPrinterJobPreview>(printer, $"https://{printer.IPAddress}/live/api/v4/jobs/{jobId}/preview/{pageNumber}?page={previewState.ToString()}");

        /// <summary>
        /// Lists data from the Fiery's job log, containing selected accounting information for each printed job.
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="count">100</param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryPrinterAccounting.PrinterJobAccounting FieryPrinterAccounting(Printer printer, int count = 100) =>
            SendGetRequest<EFI_Fiery_API.FieryPrinterAccounting.PrinterJobAccounting>(printer, $"https://{printer.IPAddress}/live/api/v4/accounting?count={count}");

        /// <summary>
        /// Lists data from the Fiery's job log, containing selected accounting information for each printed job.
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="startTime">time range relative to present time.</param>
        /// <returns></returns>
        public static EFI_Fiery_API.FieryPrinterAccounting.PrinterJobAccounting FieryPrinterAccounting(Printer printer, DateTime startTime)
        {
            long startTimeValue = -3600;
            DateTime now = DateTime.Now.Date;
            double numberofDays = (now - startTime).TotalDays;

            startTimeValue = Convert.ToInt64((numberofDays * 1440) * -3600);
            return SendGetRequest<EFI_Fiery_API.FieryPrinterAccounting.PrinterJobAccounting>(printer, $"https://{printer.IPAddress}/live/api/v4/accounting?start_time={startTimeValue}");
        }
            

        /// <summary>
        /// Send GET Request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="printer"></param>
        /// <param name="url"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static T SendGetRequest<T>(Printer printer, string url) where T : class
        {
            T response = Activator.CreateInstance<T>();

            Task task = Task.Run(async () =>
            {
                using (HttpClientHandler httpClientHandler = new HttpClientHandler())
                using (HttpClient httpClient = new HttpClient(httpClientHandler))
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url))
                {
                    CookieContainer cookieContainer = new CookieContainer();
                    cookieContainer.Add(SessionIDCookie);
                    httpClientHandler.CookieContainer = cookieContainer;

                    HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                    if (response.GetType() != typeof(EFI_Fiery_API.FieryPrinterJobPreview))
                    {
                        string data = await httpResponseMessage.Content.ReadAsStringAsync();
                        response = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(data);
                    }
                    else
                    {
                        byte[] bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();
 
                        response = (T)Convert.ChangeType(new EFI_Fiery_API.FieryPrinterJobPreview()
                        {
                            PreviewBytes = bytes
                        }, typeof(EFI_Fiery_API.FieryPrinterJobPreview));
                    }
                }
            });
            Task.WaitAll(task);
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private static async Task<EFI_Fiery_API.FieryLogin.Login> SendLoginRequest(Printer printer, string username, string password)
        {
            EFI_Fiery_API.FieryLogin.Login loginResponse = null;

            Task task = Task.Run(async () =>
            {
                try
                {
                    string url = $"https://{printer.IPAddress}/live/api/v4/login";
                    using (HttpClient httpClient = new HttpClient())
                    using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, url))
                    {
                        httpRequestMessage.Content = new StringContent(new LoginRequest(username, password).ToString(), System.Text.Encoding.UTF8, MEDIA_TYPE);
                        HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                        loginResponse = JsonConvert.DeserializeObject<EFI_Fiery_API.FieryLogin.Login>(await httpResponseMessage.Content.ReadAsStringAsync());

                        if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            SessionIDCookie = new Cookie("_session_id", GetSessionID(httpResponseMessage), "/", printer.IPAddress);
                            loginResponse.IsSuccess = true;
                        }
                        else
                        {
                            loginResponse.IsSuccess = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    loginResponse = new EFI_Fiery_API.FieryLogin.Login()
                    {
                        IsSuccess = false,
                        Error = new EFI_Fiery_API.FieryLogin.LoginError()
                        {
                            Message = ex.Message
                        }
                    };
                    loginResponse.Error.Errors = new System.Collections.Generic.List<EFI_Fiery_API.FieryLogin.ErrorElement>();
                    foreach (var error in ex.TryGetInnerExceptionsErrors().Select(x => x.Message))
                    {
                        loginResponse.Error.Errors.Add(new EFI_Fiery_API.FieryLogin.ErrorElement()
                        {
                            Message = error
                        });
                    }
                }
            });

            await task;
            return loginResponse;
        }

        /// <summary>
        /// Get Session ID
        /// </summary>
        /// <param name="httpResponseMessage"></param>
        /// <returns></returns>
        private static string GetSessionID(HttpResponseMessage httpResponseMessage) => string.Join("", httpResponseMessage.Headers.Where(x => x.Key == "Set-Cookie")
                                                                                                                           .Select(x => x.Value.First()
                                                                                                                           .Split('=')[1]
                                                                                                                           .Split(';').First()));    
    }
}