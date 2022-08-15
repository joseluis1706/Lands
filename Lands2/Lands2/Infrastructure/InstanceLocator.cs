namespace Lands2.Infrastructure
{
    using Lands2.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main 
        { 
            get; 
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
