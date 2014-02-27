using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using ScaleOut.Website.Hubs;

[assembly: OwinStartup(typeof(Startup))]
namespace ScaleOut.Website.Hubs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.UseSqlServer(ConnectionStrings.SqlServerBackplaneConnectionString);
            app.MapSignalR();
        }
    }
}