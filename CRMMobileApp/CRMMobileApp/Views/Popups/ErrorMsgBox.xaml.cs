using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRMMobileApp.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ErrorMsgBox : Popup
    {
        public ErrorMsgBox(string msg)
        {
            Message = msg;
        }

        private string message;
        public string Message
        {
            get => message;
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }
    }
}