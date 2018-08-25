using System;
namespace OptNow.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels

        public LoginViewModel Login
        {
            get;
            set;
        }

        #endregion

        #region

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }

        #endregion
    }
}
