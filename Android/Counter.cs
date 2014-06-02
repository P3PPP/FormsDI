using Xamarin.Forms;
using FormsDI;
using FormsDI.Android;

[assembly : Dependency(typeof(Counter))]

namespace FormsDI.Android
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

