using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using SignalRGroupIssue;

[assembly: OwinStartup(typeof(Startup))]

namespace SignalRGroupIssue
{
    /// <summary>
    /// Owin startup class to bootstrap SignalR rt channel
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Bootstrap SignalR rt channel
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.UseRedis("localhost", 6379, "", "SignalRBackplane");
            app.MapSignalR<RtConnection>("/rt");
        }
    }
}