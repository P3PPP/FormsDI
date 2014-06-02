﻿using Xamarin.Forms;
using FormsDI;
using FormsDI.iOS;

[assembly : Dependency(typeof(Counter))]

namespace FormsDI.iOS
{
	public class Counter : ICounter
	{
		private int count = 0;

		public Counter ()
		{
		}

		public int GetCurrent()
		{
			return count;
		}

		public int CountUp()
		{
			return ++count;
		}
	}
}
