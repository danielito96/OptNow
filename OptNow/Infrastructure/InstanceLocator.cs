﻿using System;
namespace OptNow.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region constructors

        public InstanceLocator()
        {
            this.Main = new MainViewModel();

        }

        #endregion


    }
}
