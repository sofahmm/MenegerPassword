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
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage(string name)
        {
            InitializeComponent();
            PasswordEntry.Text = name;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "1";
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "2";
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "3";
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "4";
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "5";
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "6";
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "7";
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "8";
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "9";
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.Text += "0";
        }

        private async void DoneBtn_Clicked(object sender, EventArgs e)
        {
            //if(PasswordEntry.MaxLength >= 6)
            //{
            //    DisplayAlert("Выход за предел. Пароль меньше 6!", "Пароль неверный, Переделывай!", "Ок");
            //}
            //else
            //{
            //    await Navigation.PushAsync(new ListPasswordPage());
            //}
            await Navigation.PushAsync(new ListPasswordPage());
        }
    }
}