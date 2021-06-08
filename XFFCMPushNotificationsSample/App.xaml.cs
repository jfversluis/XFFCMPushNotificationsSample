using System;
using Plugin.FirebasePushNotification;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFFCMPushNotificationsSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            CrossFirebasePushNotification.Current.Subscribe("all");
            CrossFirebasePushNotification.Current.OnTokenRefresh += Current_OnTokenRefresh;
        }

        private void Current_OnTokenRefresh(object source, FirebasePushNotificationTokenEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Token: {e.Token}");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
