using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace XFPushNotification
{
    public class PopupVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public PopupVM()
        {

        }
        private void LayoutDesign()
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

                

                var btnStack1 = new StackLayout
                {
                    Padding = 10,
                    VerticalOptions = LayoutOptions.Start,
                    HeightRequest = 50,
                    WidthRequest = 85,
                    Margin = 0,
                    Orientation = StackOrientation.Horizontal
                };


                for (int i = 0; i < buttons.Count; i++)
                {
                    DynamicModel model = (DynamicModel)buttons[i];

                    var btn = new Button
                    {
                        WidthRequest = 150,
                        HeightRequest = 50,
                        FontSize = 16,
                        FontAttributes = FontAttributes.Bold
                    };
                    btn.Text = model.Name;
                    //btn.Clicked += ;

                    btnStack1.Children.Add(btn);
                }
                //btnStack = btnStack1;
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
