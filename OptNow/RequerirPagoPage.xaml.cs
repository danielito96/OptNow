using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OptNow
{
    public partial class RequerirPagoPage : ContentPage
    {
        List<Billetera> billeteras;
        public RequerirPagoPage()
        {
            InitializeComponent();
            IntApp();
        }

        void IntApp()
        {
            billeteras = new List<Billetera>();

            billeteras.Add(new Billetera { Name = "Xapo" });
            billeteras.Add(new Billetera { Name = "Coinbase" });
            billeteras.Add(new Billetera { Name = "Otra" });

            foreach(var billetera in billeteras){

                PickerCuentaBilletera.Items.Add(billetera.Name);
            }

        }

        void PickerCuentaBilletera_SelectedIndexChanged(Object sender, EventArgs e){
            
        }

    }
}
