using System;
using System.Web;
using System.Web.UI;

namespace asp
{
	public partial class Default : System.Web.UI.Page
	{
		
		public int toggleBtn = 0;
		
		public virtual void button1Clicked (object sender, EventArgs args)
		{
			switch(toggleBtn) {
			case 0: 
				button1.Text = "You clicked me";
				break;
			case 1:
				button1.Text = "Click me!";
				Console.WriteLine("Clicked");
				break;
			}

			
				
		}
	}
}

