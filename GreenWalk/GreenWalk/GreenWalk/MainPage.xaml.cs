using GreenWalk.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GreenWalk
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void SplashButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Run());
        }

        private async void HistoriqueJourney_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Journeys());
        }

        private async void EndJourney_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EndJourney());
        }
    }
}
