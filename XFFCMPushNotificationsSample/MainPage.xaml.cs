using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.FirebasePushNotification;
using Xamarin.Forms;

namespace XFFCMPushNotificationsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                CrossFirebasePushNotification.Current.OnNotificationReceived += Current_OnNotificationReceived;
            }
        }

        private void Current_OnNotificationReceived(object source, FirebasePushNotificationDataEventArgs e)
        {
            DisplayAlert("Notification", $"Data: {e.Data["myData"]}", "OK");
        }
    }
}
