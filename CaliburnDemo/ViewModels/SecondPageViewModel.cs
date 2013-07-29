using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Caliburn.Micro.Unity.WinRT.ViewModels;
using PropertyChanged;
using Windows.UI.Popups;

namespace CaliburnDemo.ViewModels
{
    [ImplementPropertyChanged]
    public class SecondPageViewModel: ViewModelBase
    {
        public string Title { get; set; }

        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Second Page";
        }

        public void GoBack()
        {
            this.navigationService.GoBack();
        }
       
    }
}
