using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConverDegree
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ConvertButton.Clicked += ConvertButton_Clicked;
        }

        void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CelsiusEntry.Text))
            {
                DisplayAlert("Error", "You must enter a value...", "Accept");
                return;
            }
            decimal celsius = 0;
            if (!decimal.TryParse(CelsiusEntry.Text, out celsius))
            {
                DisplayAlert("Error", "You must enter a value numeric...", "Aceptar");
                CelsiusEntry.Text="";
                return;
            }
            var Fahrenheit = (celsius * 9 / 5) + 32;
            CelsiusEntry.Text = string.Format("°C {0:N2}", celsius);
            FahrenheitEntry.Text = string.Format("°F {0:N2}", Fahrenheit);
            
        }
    }
}
