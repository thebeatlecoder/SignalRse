using System.Configuration;

namespace ScaleOut.Website
{
    internal static class ConnectionStrings
    {
        internal static string SqlServerBackplaneConnectionString =
            ConfigurationManager.ConnectionStrings["SqlServerBackplane"].ConnectionString;
    }
}