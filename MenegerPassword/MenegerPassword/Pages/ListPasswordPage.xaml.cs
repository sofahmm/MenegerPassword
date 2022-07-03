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
    public partial class ListPasswordPage : ContentPage
    {
        public ListPasswordPage()
        {
            InitializeComponent();
           
        }
        protected override void OnAppearing()
        {
            AccountLv.ItemsSource = App.Repos.GetAccounts();
            base.OnAppearing();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPasswordPage());
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}