using System.Security.Principal;

namespace Owasp.AppSensor.Demo.Api.Filters
{
    public  class BasicAuthenticationIdentity : IIdentity
    {
        public string Name
        {
            get; set;
        }

        public string AuthenticationType { get; }
        public bool IsAuthenticated { get; }

        public string Password
        {
            get; set;
        }

        public BasicAuthenticationIdentity(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}