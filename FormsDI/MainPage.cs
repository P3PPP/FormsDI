using Xamarin.Forms;

namespace FormsDI
{
	public class MainPage : ContentPage
	{
		public MainPage ()
		{
			var count = new Button {
				Text = "Click Me!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			count.Clicked += (sender, e) => {
				count.Text = 
					DependencyService.Get<ICounter>(
//						DependencyFetchTarget.NewInstance
						DependencyFetchTarget.GlobalInstance
					).CountUp()
					+ " times clicked!";
			};
			Content = count;
		}
	}
}

