using GreenWalk.Services;
using GreenWalkModel;
using System.Collections.ObjectModel;
using System.Linq;
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
                    Pseudo = "https://picsum.photos/500"
                };
            }

            MyListView.ItemsSource = AllJourneys;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            Navigation.PushAsync(new DetailJourney());
        }
    }
}
