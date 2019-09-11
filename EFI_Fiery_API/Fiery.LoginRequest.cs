using Newtonsoft.Json;

namespace EFI
{
    public partial class Fiery
    {
        private class LoginRequest
        {
            public string username { get; set; }
            public string password { get; set; }
            public string accessrights = AccessKey;
            public LoginRequest(string username, string password) => (this.username, this.password) = (username, password);

            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }
    }
}