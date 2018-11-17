using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GreenWalk.Pages
{
    public partial class EndJourney : ContentPage
    {
        public double Distance { get; set; }

        public TimeSpan Duree { get; set; }

        public EndJourney(double distance, TimeSpan duree)
        {
            InitializeComponent();
            Distance = distance;
            Duree = duree;
            AjouterImage.Source = ImageSource.FromFile("ajouterphoto.png");
            BindingContext = this;
        }

        private async void Enregistrer_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
