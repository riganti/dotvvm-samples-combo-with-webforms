using DotVVM.Framework.Configuration;

namespace WebFormsDotVVMCombo
{
    public class DotvvmStartup : IDotvvmStartup
    {
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Admin", "admin", "Views/Admin.dothtml");
        }
    }
}