using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPushNotification
{
    public partial class NotificationListPage : ContentPage
    {
        public NotificationListPage(string title, string message)
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblMessage.Text = message;
        }
    }
}