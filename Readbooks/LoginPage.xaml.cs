using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Readbooks
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

      async  void Login_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                Dictionary<String, String> keyValuePairs = new Dictionary<string, string> {
                    {"user","jonchusGP" },
                    {"network","Wifi" }
                
                };
                AppCenterHelper.TrackEvent("logged_in", keyValuePairs);
                await Navigation.PopModalAsync(true);
                //throw new Exception("An error occured. Check it out!");
            }
            catch (Exception ex){

                Dictionary<String, String> keyValuePairs = new Dictionary<string, string> {
                    {"user","jonchusGP" },
                    {"network","Wifi" }
                   };

                AppCenterHelper.TrackError(ex,keyValuePairs);

            }
        }
    }
}
