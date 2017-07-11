using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.Forms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();
			createContent();
		}
		public void createContent()
		{
			
			StackLayout layout = new StackLayout();
			this.Title = "LiftMore";
			Content = new PlotView
			{

				Model = new PlotModel
				{
					Title = "OxyPlot in Xamarin Forms.",
					Axes =
						{
							new CategoryAxis {Position = AxisPosition.Bottom},
							new LinearAxis {Position = AxisPosition.Left, MinimumPadding = 0}
						},
					Series =
						{
							new ColumnSeries
							{
								Items =
								{
									new ColumnItem {Value = 3},
									new ColumnItem {Value = 14},
									new ColumnItem {Value = 11},
									new ColumnItem {Value = 12},
									new ColumnItem {Value = 7}
								}
							}
						}
				},
				VerticalOptions = LayoutOptions.Fill,
				HorizontalOptions = LayoutOptions.Fill
			};
				
			
			//layout.Children.Add(content);
			//this.Content. new NavigationPage(content);
			//Content = this.Content;
			//Content = content;
		}
	}
}