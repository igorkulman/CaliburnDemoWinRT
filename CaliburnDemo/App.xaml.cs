using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227
using Caliburn.Micro.Unity.WinRT.Code;

namespace CaliburnDemo
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : CaliburnUnityApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            //For any state other than running, we need to rewire the SettingsFlyout
            if (args.PreviousExecutionState != ApplicationExecutionState.Running)
            {
                await DisplayRootView(typeof(MainView));              
            }
        }

    }
}
