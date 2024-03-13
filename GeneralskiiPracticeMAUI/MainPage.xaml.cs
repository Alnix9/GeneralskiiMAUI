using Newtonsoft.Json;
using System.Net;

namespace GeneralskiiPracticeMAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            var delivery = new WebClient();
            var response = delivery.DownloadString("http://localhost:54156/api/Deliveries");
            lvDeliveries.ItemsSource = JsonConvert.DeserializeObject<List<Deliveries>>(response);

        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {

        }
    }
}
