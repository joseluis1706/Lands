namespace Lands2
{
    using Lands2.Views;
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;


    public partial class App : Application
    {
        #region Constructor

        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage());
        }
        #endregion

        #region Metodos
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion
    }
}
