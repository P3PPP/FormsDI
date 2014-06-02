using System;
using Xamarin.Forms;

namespace FormsDI
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new MainPage ();
		}
	}
}

