using Owin;
using PetesWebThing2.Models;

namespace PetesWebThing2
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
        }
    }
}
