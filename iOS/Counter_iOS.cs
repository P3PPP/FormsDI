using Xamarin.Forms;
using FormsDI;
using FormsDI.iOS;

[assembly : Dependency(typeof(Counter_iOS))]

namespace FormsDI.iOS
{
	public class Counter_iOS : ICounter
	{
		private int count = 0;

		public Counter_iOS ()
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

