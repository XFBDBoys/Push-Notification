using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFPushNotification.IServices;

namespace XFPushNotification
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void SendNotification(object sender, EventArgs e)
        {
            DependencyService.Get<INotification>().CreateNotification("XFBDBoys", message.Text);
        }

        private async void Dashboard_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DashboardPage());
        }
    }
}
