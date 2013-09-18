using System;
using Caliburn.Micro.Unity.WinRT.Common;
using CaliburnDemo.Servcies;
using Microsoft.Practices.Unity;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227
using Caliburn.Micro.Unity.WinRT.Code;
using CaliburnDemo.Views;

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

        protected override void Configure()
        {
            container.RegisterType<IProductService, ProductService>(new ContainerControlledLifetimeManager());
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {            
            if (args.PreviousExecutionState != ApplicationExecutionState.Running)
            {
                await DisplayRootView(typeof(MainView));              
            }
        }

        protected override async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            base.OnSuspending(sender, e);
            var deferal = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
            deferal.Complete();
        }

    }
}
