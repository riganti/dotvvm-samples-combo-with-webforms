using System;
using System.Threading.Tasks;
using System.Web.Hosting;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebFormsDotVVMCombo.Startup))]

namespace WebFormsDotVVMCombo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var applicationPath = HostingEnvironment.ApplicationPhysicalPath;

            app.UseDotVVM<DotvvmStartup>(applicationPath);
        }
    }
}
