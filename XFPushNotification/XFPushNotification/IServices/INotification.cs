using System;
using System.Collections.Generic;
using System.Text;

namespace XFPushNotification.IServices
{
    public interface INotification
    {
        void CreateNotification(String title, String message);
    }
}
