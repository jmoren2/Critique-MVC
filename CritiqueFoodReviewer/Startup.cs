using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CritiqueFoodReviewer.Startup))]
namespace CritiqueFoodReviewer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
