﻿using CRMMobileApp.Core;
using CRMMobileApp.Views.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRMMobileApp.Views.Pages.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainEquipmentPage : ContentPage
    {
        public MainEquipmentPage()
        {
            InitializeComponent();
        }

        #region Навигация между вкладками
        private ICommand goToMainMenuPage;
        public ICommand GoToMainMenuPage
        {
            get => goToMainMenuPage ??= new RelayCommand(async obj => await App.Current.MainPage.Navigation.PushAsync(new MainMenuPage()));
        }
        private ICommand goToEquipmentPage;
        public ICommand GoToEquipmentPage
        {
            get => goToEquipmentPage ??= new RelayCommand(async obj => await App.Current.MainPage.Navigation.PushAsync(new MainEquipmentPage()));
        }
        private ICommand goToStockPage;
        public ICommand GoToStockPage
        {
            get => goToStockPage ??= new RelayCommand(async obj => await App.Current.MainPage.Navigation.PushAsync(new MainStockPage()));
        }
        #endregion

        private ICommand showAboutSoftwarePopup;
        public ICommand ShowAboutSoftwarePopup
        {
            get => showAboutSoftwarePopup ??= new RelayCommand(async obj => await App.Current.MainPage.Navigation.ShowPopupAsync(new AboutSoftware()));
        }
    }
}