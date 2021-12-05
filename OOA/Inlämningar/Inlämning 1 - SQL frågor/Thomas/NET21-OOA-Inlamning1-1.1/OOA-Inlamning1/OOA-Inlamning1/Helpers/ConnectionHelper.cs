namespace OOA_Inlamning1.Helpers
{
    using System.Configuration;

    public static class ConnectionHelper
    {
        public static string CnnStr(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}