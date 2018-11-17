using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace GreenWalk.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Map : ContentPage
	{
		public Map ()
		{
			InitializeComponent ();
            Xamarin.Forms.Maps.Map map = new Xamarin.Forms.Maps.Map(
                MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromKilometers(0.5)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
		}
	}
}