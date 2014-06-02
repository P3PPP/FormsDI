using Xamarin.Forms;
using FormsDI;
using FormsDI.Android;

[assembly : Dependency(typeof(Counter_Android))]

namespace FormsDI.Android
{
	public class Counter_Android : ICounter
	{
		private int count = 0;

		public Counter_Android ()
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

