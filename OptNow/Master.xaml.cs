using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OptNow
{
    using Views;
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
           
        }

        private async void MisReferidosButton_Clicked(object sender, EventArgs e){

            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new MisReferidosPage());
        }

        private async void RequerirPagoButton_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new RequerirPagoPage());

        }
        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new LoginPage());

        }
    }
}
