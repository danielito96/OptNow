using System;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace OptNow.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;

        #endregion


        #region Properties
        public String Email
        {
            get;
            set;
        }

        public String Password
        {
            get { return password; }
            set
            {
                if(this.password != value)
                {
                    this.password = value;
                    PropertyChanged?.Invoke(
                    this,
                        new PropertyChangedEventArgs(nameof(this.Password)));
                }
            }
        }

        public Boolean IsRunning
        {
            get { return isRunning; }
            set
            {
                if (this.isRunning != value)
                {
                    this.isRunning = value;
                    PropertyChanged?.Invoke(
                    this,
                        new PropertyChangedEventArgs(nameof(this.IsRunning)));
                }
            }
        }

        public Boolean IsRemember
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                if (this.isEnabled != value)
                {
                    this.isEnabled = value;
                    PropertyChanged?.Invoke(
                    this,
                        new PropertyChangedEventArgs(nameof(this.IsEnabled)));
                }
            }
        }


        #endregion

        #region Constructors

        public LoginViewModel()
        {
            this.IsRemember = true;
            this.IsEnabled = true;
        }

        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get 
            {
                return new RelayCommand(Login);
            }

        }

        private async void Login(){
            if(string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a password",
                    "Accept");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = true;

            if (this.Email != "daniel@gmail.com" || this.Password == "1234")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or Password is incorrect",
                    "Accept");
                return;
            }

        }



        #endregion
    }
}
