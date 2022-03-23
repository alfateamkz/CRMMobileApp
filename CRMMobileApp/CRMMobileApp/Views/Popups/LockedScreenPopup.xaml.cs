using CRMMobileApp.Core;
using CRMMobileApp.Views.Pages.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRMMobileApp.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LockedScreenPopup : Popup
    {
        public LockedScreenPopup()
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
                    App.Current.MainPage.Navigation.ShowPopup(new OneButtonedPopup("Неверный пинкод", "Название CRM"));
                }
                else if (Password == "0000")
                {
                    Dismiss(null);
                }
                password = value;
                OnPropertyChanged(nameof(Password));

            }
        }

        private ICommand logout;
        public ICommand Logout
        {
            get => logout ??= new RelayCommand(async obj =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                Dismiss(null);
            });
        }
    }
}