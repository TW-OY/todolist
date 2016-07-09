using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoLists.Startup))]
namespace ToDoLists
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
