using CRMMobileApp.Core;
using CRMMobileApp.Views.Pages.Main;
using CRMMobileApp.Views.Pages.Orders;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private string domain = string.Empty;
        public string Domain
        {
            get => domain;
            set { domain = value; OnPropertyChanged(nameof(Domain)); }
        }
        private string username = string.Empty;
        public string Username
        {
            get => username;
            set { username = value; OnPropertyChanged(nameof(Username)); }
        }
        private string password = string.Empty;
        public string Password
        {
            get => password;
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }
    
    }
}
