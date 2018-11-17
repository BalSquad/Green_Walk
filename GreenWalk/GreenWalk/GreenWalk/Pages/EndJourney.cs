using System;

using Xamarin.Forms;

namespace GreenWalk.Pages
{
    public class EndJourney : ContentPage
    {
        public EndJourney()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

