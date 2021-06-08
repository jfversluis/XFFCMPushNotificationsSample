using System;
using System.Collections.Generic;
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;

namespace XFFCMPushNotificationsSample.Send
{
    class Program
    {
        static void Main(string[] args)
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("private_key.json")
            });

            // This registration token comes from the client FCM SDKs.
            //var registrationToken = "TOKEN_HERE";

            // See documentation on defining a message payload.
            var message = new Message()
            {
                Data = new Dictionary<string, string>()
    {
        { "myData", "1337" },
    },
                //Token = registrationToken,
                Topic = "all",
                Notification = new Notification()
                {
                    Title = "Test from code",
                    Body = "Here is your test!"
                }
            };

            // Send a message to the device corresponding to the provided
            // registration token.
            string response = FirebaseMessaging.DefaultInstance.SendAsync(message).Result;
            // Response is a message ID string.
            Console.WriteLine("Successfully sent message: " + response);
        }
    }
}
