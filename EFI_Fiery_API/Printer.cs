using System;

namespace EFI
{
    public partial class Fiery
    {
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
    }
}