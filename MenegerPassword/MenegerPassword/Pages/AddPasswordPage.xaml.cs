using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MenegerPassword.SQLite;

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

        private async void OtmenaBtn_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }

        private async void SaveBtn_Clicked(object sender, EventArgs e)
        {
            //var account = (Account)BindingContext;
            //if (!String.IsNullOrEmpty(account.Login))
            //    App.Repos.SaveAccount(account);
            //await this.Navigation.PopAsync();
            Account account = new Account();
            account.Login = LoginEntry.Text.Trim();
            account.Password = PasswordEntry.Text.Trim();
            account.Url = UrlEntry.Text.Trim();
            account.Type = Type.SelectedItem.ToString();
            App.Repos.SaveAccount(account);
            Navigation.PopAsync();
        }
    }
}