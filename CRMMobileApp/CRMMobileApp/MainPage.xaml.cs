using CRMMobileApp.Core;
using CRMMobileApp.Views.Pages.Main;
using CRMMobileApp.Views.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace CRMMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            keyboard.ButtonTapped += Keyboard_ButtonTapped;
        }

        private void Keyboard_ButtonTapped(object sender, string e)
        {
            if (e == "backspace" && Password.Length > 0)
                Password = Password.Remove(Password.Length - 1);
            else if (e != "backspace")
                Password += e;

        }

        private string password = string.Empty;
        public string Password
        {
            get => password;
            set
            {
                if (Password != "0000" && Password.Length == 4)
                {
                    App.Current.MainPage.Navigation.ShowPopup(new ClientsPopup());
                }
                else if (Password == "0000")
                {
                    App.Current.MainPage.Navigation.PushAsync(new MainMenuPage());
                }
                password = value; 
                OnPropertyChanged(nameof(Password));
            
            }
        }
    
    }
}
