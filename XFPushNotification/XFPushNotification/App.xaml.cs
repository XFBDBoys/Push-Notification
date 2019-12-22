using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Forms.Controls;

namespace XFPushNotification
{
    public partial class App : Application
    {
        //public App(bool shallNavigate)
        //{
        //    InitializeComponent();

        //    if (shallNavigate)
        //    {
        //        MainPage = new NavigationPage(new NotificationListPage());
        //    }
        //    else
        //    {
        //        MainPage = new NavigationPage(new MainPage());
        //    }

        //}

        public App(bool flag, string title, string message)
        {
            InitializeComponent();

            if (flag)
            {
                //Type CurrentPage = 
                //MainPage = new NavigationPage(new NotificationListPage(title, message));
                //Application.Current.MainPage.Navigation.PushPopupAsync(new NotificationPopupPage(title, message));
                MainPage = new NavigationPage(new NotificationPopupPage(title, message, null));

                //popup.ShowPopup(label);
                //popup.ShowPopup(new PopupView(title, message));
                //var aaa = new PopupView(title, message);
                //MainPage = new ContentPage
                //{
                //    HeightRequest=50,
                //    WidthRequest = 50,
                //    Content = aaa
                //};
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }

            

        }

       
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
