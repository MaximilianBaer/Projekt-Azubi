using Microsoft.Owin;
using Owin;
using Domain.Acces;
using System;
using System.Data.Entity;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(mvc.Startup))]
namespace mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            s(); 
        }



        private void s()
        {
            // datenbank ewrstell, testdaten code code 
            CreateDatabase.test();
        }  
    }
}
