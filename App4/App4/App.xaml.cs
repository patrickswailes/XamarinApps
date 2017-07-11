using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App4
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new App4.MainPage();
			SetMainPage();
		}

		public static void SetMainPage()
		{
			Current.MainPage = new TabbedPage
			{
				Children =
				{
					new NavigationPage(new TableView())
					{
						Title = "Exercises",
						Icon = Device.OnPlatform("tab_feed.png",null,null)
					},
					new NavigationPage(new MainPage())
					{
						Title = "Workout",
						Icon = Device.OnPlatform("tab_about.png",null,null)
					},
					new NavigationPage(new Page1())
					{
						Title = "Graphs",
						Icon = Device.OnPlatform("tab_about.png",null,null)
					},
				}
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
