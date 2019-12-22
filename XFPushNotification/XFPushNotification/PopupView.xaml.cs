using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPushNotification
{
    public partial class PopupView : ContentView
    {
        public PopupView(string title, string message)
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblMessage.Text = message;
        }

        private async void btnDismiss_Clicked(object sender, EventArgs e)
        {
            //await App.Current.MainPage.Navigation.PopAsync();
            //var currentPage = navPage.Navigation.NavigationStack[index];

            //var vm = currentPage.BindingContext as ViewModel;

            //if (vm != null)
            //{
            //    var answer = vm.OnBackButtonPressed();
            //    if (answer)
            //        return true;
            //}
        }
    }
}