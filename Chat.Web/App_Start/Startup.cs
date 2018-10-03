using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Chat.Web.App_Start.Startup))]

namespace Chat.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.Configuration.ConnectionTimeout = TimeSpan.FromSeconds(110);
            GlobalHost.Configuration.DisconnectTimeout = TimeSpan.FromSeconds(60);
            GlobalHost.Configuration.KeepAlive = TimeSpan.FromSeconds(20);
            HubConfiguration hubConfiguration = new HubConfiguration
            {
                EnableDetailedErrors = true
            };
            app.MapSignalR(hubConfiguration);
        }
    }
}
