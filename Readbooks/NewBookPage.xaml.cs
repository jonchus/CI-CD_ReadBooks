using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Readbooks
{
    public partial class NewBookPage : ContentPage
    {
        public NewBookPage()
        {
            InitializeComponent();
        }

        void SaveButton_Clicked(object sender, System.EventArgs e)
        {
            Books books = new Books {
                Author = "",
                ISBN = "",
                Name = "",
                Publisher = ""

            };
            books.SaveBook();
        }
    }
}
