using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			//title = new Label("LIFT NOW");
			this.Title = "LiftMore";
			Content = new Label
			{
				Text = "Lift Now",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				//VerticalOptions = LayoutOptions.CenterAndExpand,
				//HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}
