using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using MenegerPassword.SQLite;
using System.IO;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "PasswordFont")]

namespace MenegerPassword
{
    public partial class App : Application
    {
        static Repos repos;

        public static Repos Repos
        {
            get
            {
                if (repos == null)
                {
                    repos = new Repos(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjecttsDatabase.db3"));
                }
                return repos;
            }

        }
        public App()
        {
            InitializeComponent();

            //if (App.repos.IsNewUser())
            //    MainPage = new NavigationPage(new Pages.AddPasswordPage())
            //{ BarBackgroundColor = Color.FromRgb(0, 0, 0), BarTextColor = Color.White };
            //else
            //    MainPage = new NavigationPage(new Pages.AuthorizationPage(App.repos.GetUser(1))) { BarBackgroundColor = Color.FromRgb(0, 0, 0), BarTextColor = Color.White };
            MainPage = new NavigationPage(new Pages.RegistrationPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
