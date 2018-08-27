using System;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace OptNow.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
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
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public Boolean IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public Boolean IsRemember
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
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
            this.IsEnabled = false;

            if (this.Email != "daniel@gmail.com" || this.Password == "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
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
