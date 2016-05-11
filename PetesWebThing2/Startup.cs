using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PetesWebThing2.Startup))]

namespace PetesWebThing2
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}
