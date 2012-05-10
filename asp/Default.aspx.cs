using System;
using System.Web;
using System.Web.UI;
using System.Configuration;

namespace asp
{
	
	public partial class Default : System.Web.UI.Page
	{

		public static int toggleBtn = 0;
		
		
		void Page_Load()
		{
			// VCAP variables are accessed from web.config
			// this is a trivial example just to show how to grab a value
			ipaddr.Text = ConfigurationManager.AppSettings["VCAP_APP_HOST"] ?? "localhost";
		}
		
		public virtual void button1Clicked (object sender, EventArgs args)
		{			
			switch(toggleBtn) {
			
			case 0: 
				button1.Text = "You clicked me";
				toggleBtn = 1;
				break;

			case 1:
				button1.Text = "Click me!";
				toggleBtn = 0;
				// Console.WriteLine("Clicked"); // no console output on CF
				break;
			}			
				
		}
	}
}

