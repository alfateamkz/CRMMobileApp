using CRMMobileApp.Core;
using CRMMobileApp.Views.Pages.Tables;
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
    public partial class MainStockPage : ContentPage
    {
        public MainStockPage()
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

        #region Кнопки в гриде
        private ICommand goToSalesByIngridient;
        public ICommand GoToSalesByIngridient
        {
            get => goToSalesByIngridient ??= new RelayCommand(async obj => await App.Current.MainPage.Navigation.PushAsync(new SalesByIngridients()));
        }
        private ICommand goToBalanceAtStock;
        public ICommand GoToBalanceAtStock
        {
            get => goToBalanceAtStock ??= new RelayCommand(async obj => await App.Current.MainPage.Navigation.PushAsync(new BalanceAtStock()));
        }
        private ICommand goToSalesOnDuty;
        public ICommand GoToSalesOnDuty
        {
            get => goToSalesOnDuty ??= new RelayCommand(async obj => await App.Current.MainPage.Navigation.PushAsync(new SalesOnDuty()));
        }
        #endregion

        private ICommand showAboutSoftwarePopup;
        public ICommand ShowAboutSoftwarePopup
        {
            get => showAboutSoftwarePopup ??= new RelayCommand(async obj => await App.Current.MainPage.Navigation.ShowPopupAsync(new AboutSoftware()));
        }
    }
}