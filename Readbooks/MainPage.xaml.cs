﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Readbooks
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Login_Button_Clicked(object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("login_intent");
            await Navigation.PushModalAsync(new LoginPage());
        }

        async void AddNew_Book_Clicked(object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("add_book_intent");
            await Navigation.PushAsync(new NewBookPage());
        }
    }
}
