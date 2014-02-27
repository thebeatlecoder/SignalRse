using System.Configuration;

namespace ScaleOut.CustomerUpdates
{
    internal static class AppSettings
    {
        internal static readonly string CustomerUpdateHubUrl = ConfigurationManager.AppSettings["CustomerUpdateHubUrl"];
        internal static readonly string CustomerUpdateHubName = ConfigurationManager.AppSettings["CustomerUpdateHubName"];
    }
}