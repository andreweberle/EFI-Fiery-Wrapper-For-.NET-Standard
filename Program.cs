using System;
using EFI;

namespace myApplicationName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assign AccessKey From EFI
            Fiery.AccessKey = "ppQrmZl2FVvlMOsvJudZkkve3sdQEm8sD3s4y0e0OZ+u+n1wq+J9nNaV14n+sSKPwRjgbIE4IASc5sAVoMYdvQUslkmfyplZTlrlJeg5Nv+43Nlzchgkfv7LZYObqVkjX42xuJt6fqoAJ4TtL4QrWv4u79z0cLlj0+53t3encpmvjKMBq6igNma8+OTorQLq1+R0YmD3HsAqBjjqPba13PdnYLaGaeTQAe3Pm+lvWCmn/apO12cSuAsAd4RDqgpcB4MZiHguIMalkn0ZboGr2oDgTMxMl5kBnURKyT+/pT3lj8cdkLrxwdrrnIfl2v1LQB1eyuaCNkmRFM0xa05jVz/DVb5T5plkLIfDcDILIAjKCckvnT95+IoSeOV0nzinWDhLGbU0F0xxKR/L27rt031pQiSVqnXunHzOYEH5VGB6ROMuoc8NZ2oXNakRvz4tPxWkazvx5du3EvKExxiIaXq5owhLO9+HLXQHS77F+equeXjWgdAtw9RMHRj7Jy/0";

            // Create New Printer.
            Fiery.Printer printer = new Fiery.Printer()
            {
                IPAddress = "10.0.0.70"
            };

            // UserName
            string username = "Admin";
            string password = "Firey.1";

            // Login
            if (Fiery.Login(printer, username, password).IsSuccess)
            {
                Console.WriteLine("IN");
            }

            Console.Read();
        }
    }
}
