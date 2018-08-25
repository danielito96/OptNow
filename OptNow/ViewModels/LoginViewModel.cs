using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace OptNow.ViewModels
{
    public class LoginViewModel
    {
        #region Properties
        public String Email
        {
            get;
            set;
        }

        public String Password
        {
            get;
            set;
        }

        public Boolean IsRunning
        {
            get;
            set;
        }

        public Boolean IsRemember
        {
            get;
            set;
        }


        #endregion

        #region Constructors

        public LoginViewModel()
        {
            this.IsRemember = true;
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

        }



        #endregion
    }
}
