namespace Owasp.AppSensor.Demo.Api.Filters
{
    public  class BasicAuthenticationIdentity
    {
        private string Name
        {
            get; set;
        }
        private string Password
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