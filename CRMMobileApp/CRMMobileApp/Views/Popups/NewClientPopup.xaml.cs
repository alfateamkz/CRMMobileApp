using CRMMobileApp.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class NewClientPopup : Popup
    {
        public NewClientPopup()
        {
            InitializeComponent();
        }

        #region INPC свойства
        private string surname = string.Empty;
        public string Surname
        {
            get => surname;
            set { surname = value; OnPropertyChanged(nameof(Surname)); }
        }
        private string name = string.Empty;
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }
        private string patronymic = string.Empty;
        public string Patronymic
        {
            get => patronymic;
            set { patronymic = value; OnPropertyChanged(nameof(Patronymic)); }
        }
        private string phone = string.Empty;
        public string Phone
        {
            get => phone;
            set { phone = value; OnPropertyChanged(nameof(Phone)); }
        }
        private string cardNumber = string.Empty;
        public string CardNumber
        {
            get => cardNumber;
            set { cardNumber = value; OnPropertyChanged(nameof(CardNumber)); }
        }
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set { birthDate = value; OnPropertyChanged(nameof(BirthDate)); }
        }
        private ObservableCollection<string> genders = new ObservableCollection<string>() { "Мужской","Женский"};
        public ObservableCollection<string> Genders
        {
            get => genders;
            set { genders = value; OnPropertyChanged(nameof(Genders)); }
        }
        private string selectedGender;
        public string SelectedGender
        {
            get => selectedGender;
            set { selectedGender = value; OnPropertyChanged(nameof(SelectedGender)); }
        }
        #endregion

        #region Команды
        private ICommand close;
        public ICommand Close
        {
            get => close ??= new RelayCommand(async obj =>
            {
                Dismiss(null);
            });
        }
        private ICommand createClient;
        public ICommand CreateClient
        {
            get => createClient ??= new RelayCommand(async obj =>
            {
                Dismiss(null);
            });
        }
        private ICommand createClientAndAttach;
        public ICommand CreateClientAndAttach
        {
            get => createClientAndAttach ??= new RelayCommand(async obj =>
            {
                Dismiss(null);
            });
        }
        #endregion
    }
}