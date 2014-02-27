using System.Configuration;

namespace ScaleOut.CustomerUpdate.Service
{
    internal static class AppSettings
    {
        internal static readonly string ServiceName = ConfigurationManager.AppSettings["ServiceName"];
        internal static readonly string ServiceDisplayName = ConfigurationManager.AppSettings["ServiceDisplayName"];
    }
}