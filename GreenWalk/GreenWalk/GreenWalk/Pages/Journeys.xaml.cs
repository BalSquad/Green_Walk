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

            foreach(Journey j in AllJourneys)
            {
                j.User = new User()
                {
                    FirstName = "Lucas",
                    LastName = "Tambarin",
                    Pseudo = "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=2ahUKEwj93-Ta9dreAhUDNOwKHb_QDmUQjRx6BAgBEAU&url=https%3A%2F%2Fwww.churchtrac.com%2Farticles%2Finsert-logo-here%2F&psig=AOvVaw0Z_hWefV7k5fNPDXSNyOln&ust=1542526218359916"
                };
            }

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
