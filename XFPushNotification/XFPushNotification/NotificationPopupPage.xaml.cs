using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPushNotification
{
    public partial class NotificationPopupPage : PopupPage
    {
        Type page;
        public Type Page
        {
            get
            {
                return page;
            }
            set
            {
                page = value;
            }
        }
        public NotificationPopupPage(string title, string message, Type CurrentPage)
        {
            LayoutDesign(title, message);
            InitializeComponent();
            nfTitle.Text = title;
            nfDetails.Text = message;
            Page = CurrentPage;
        }

        private void LayoutDesign(string title, string message)
        {
            try
            {
                List<DynamicModel> buttons = new List<DynamicModel>()
                {
                    new DynamicModel{ID = 1, Name="Register", Action = "Register_Clicked"},
                    new DynamicModel{ID = 2, Name="OK",Action="OK_Clicked"},
                    new DynamicModel{ID = 3, Name="SignIN",Action="SignIN_Clicked"},
                    new DynamicModel{ID = 4, Name="Cancel",Action="Cancel_Clicked"}
                };

                //var Stack = new StackLayout
                //{
                //    VerticalOptions = LayoutOptions.Start,
                //    Margin = 0,
                //    Orientation = StackOrientation.Vertical
                //};

                //var lblTitle = new Label
                //{
                //    FontSize = 20,
                //    FontAttributes = FontAttributes.Bold,
                //    HorizontalOptions = LayoutOptions.CenterAndExpand,
                //    VerticalOptions = LayoutOptions.StartAndExpand
                //};
                //lblTitle.Text = title;

                //var lblSMS = new Label
                //{
                //    FontSize = 16,
                //    FontAttributes = FontAttributes.Bold,
                //    HorizontalOptions = LayoutOptions.CenterAndExpand,
                //    VerticalOptions = LayoutOptions.StartAndExpand
                //};
                //lblSMS.FontSize = 16;

                //Stack.Children.Add(lblTitle);
                //Stack.Children.Add(lblSMS);
                StackLayout parent;
                parent = btnStack;
                //var btnStack1 = new StackLayout
                //{
                //    Padding = 10,
                //    VerticalOptions = LayoutOptions.Start,
                //    HeightRequest = 50,
                //    WidthRequest = 85,
                //    Margin = 0,
                //    Orientation = StackOrientation.Horizontal
                //};


                for (int i = 0; i < buttons.Count; i++)
                {
                    DynamicModel model = (DynamicModel)buttons[i];

                    Button newButton = new Button { Text = model.Name };
                    newButton.SetBinding(Button.CommandProperty, new Binding(model.Action));
                    //newButton.BindingContext = PopupVM;

                    parent.Children.Add(newButton);
                    //var btn = new Button
                    //{
                    //    WidthRequest = 150,
                    //    HeightRequest = 50,
                    //    FontSize = 16,
                    //    FontAttributes = FontAttributes.Bold
                    //};
                    //btn.Text = model.Name;
                    ////btn.Clicked += ;

                    //btnStack.Children.Add(btn);
                }
                //btnStack.Children.Add(btn);
            }
            catch (Exception ex)
            {
                this.DisplayAlert("Exception", ex.Message.ToString(), "OK");
            }
        }

        private void btnRegistration_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            try
            {
                //await  Navigation.PopPopupAsync();
                //await PopupNavigation.Instance.RemovePageAsync(this);
                await PopupNavigation.Instance.RemovePageAsync(this);
            }
            catch (Exception)
            {
                await PopupNavigation.Instance.RemovePageAsync(this);
            }

        }
    }
}