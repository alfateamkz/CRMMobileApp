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
    public partial class OneButtonedMsgBox : Popup
    {
        public OneButtonedMsgBox(string msg,string caption)
        {
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
    }
}