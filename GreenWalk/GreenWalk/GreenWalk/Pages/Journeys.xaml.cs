using GreenWalk.Models;
using GreenWalk.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWalk.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Journeys : ContentPage
    {
        public ObservableCollection<Journey> AllJourneys { get; set; } 

        public ObservableCollection<string> Items { get; set; }

        public Journeys()
        {
            InitializeComponent();

            //UserId
            AllJourneys = new ObservableCollection<Journey>(JourneyService.GetJourneysByUser(1).AsEnumerable());

            MyListView.ItemsSource = AllJourneys;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
