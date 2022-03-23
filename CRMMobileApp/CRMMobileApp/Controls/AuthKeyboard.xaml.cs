using CRMMobileApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRMMobileApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthKeyboard : ContentView
    {
        public event EventHandler<string> ButtonTapped;
        public AuthKeyboard()
        {
            InitializeComponent();
        }

        private ICommand tapButton;
        public ICommand TapButton
        {
            get => tapButton ??= new RelayCommand(async obj =>
            {
                ButtonTapped?.Invoke(this, obj as string);
            });
        }
    }
}