using Caliburn.Micro;
using Caliburn.Micro.Unity.WinRT.ViewModels;
using PropertyChanged;
using Windows.UI.Popups;

namespace CaliburnDemo.ViewModels
{
    [ImplementPropertyChanged]
    public class MainViewModel: ViewModelBase
    {
        public string Title { get; set; }

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Caliburn Demo";
        }

        public void GoToSecondPage()
        {
            navigationService.UriFor<SecondPageViewModel>().WithParam(l=>l.Title, "Navigated from MainViewModel").Navigate();
        }
    }
}
