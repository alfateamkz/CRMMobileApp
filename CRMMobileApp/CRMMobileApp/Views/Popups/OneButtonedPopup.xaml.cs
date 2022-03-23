using CRMMobileApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRMMobileApp.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OneButtonedPopup : Popup
    {
        public OneButtonedPopup(string msg, string caption)
        {
            InitializeComponent();
            Message = msg;
            Caption = caption;
        }

        private string caption;
        public string Caption
        {
            get => caption;
            set { caption = value; OnPropertyChanged(nameof(Caption)); }
        }
        private string message;
        public string Message
        {
            get => message;
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }

        private ICommand close;
        public ICommand Close
        {
            get => close ??= new RelayCommand(async obj =>
            {
                Dismiss(null);
            });
        }
    }
}