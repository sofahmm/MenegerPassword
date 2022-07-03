using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenegerPassword.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPasswordPage : ContentPage
    {
        public AddPasswordPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTypePage());
        }

        private void OtmenaBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}