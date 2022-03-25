﻿using CRMMobileApp.Core;
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
    public partial class ErrorPopup : Popup
    {
        public ErrorPopup()
        {
            InitializeComponent();
        }
        private ICommand close;
        public ICommand Close
        {
            get => close ??= new RelayCommand(async obj => Dismiss(null));
        }
    }
}