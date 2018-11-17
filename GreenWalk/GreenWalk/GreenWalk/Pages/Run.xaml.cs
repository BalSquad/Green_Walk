using GreenWalk.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWalk.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Run : ContentPage
	{
        public Timer Timer { get; set; }

		public Run ()
		{
            Timer = new Timer();
            BindingContext = Timer;
            Timer.Start();
            InitializeComponent ();
		}

        private void Stop_Clicked(object sender, EventArgs e)
        {
            Timer.Stop();
            TimerDisplay.Text = String.Format("Temps écoulé : {0}",Timer.TimeSpent);

            Navigation.PushAsync(new EndJourney());
        }
    }
}