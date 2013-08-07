using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Caliburn.Micro.Unity.WinRT.Code;
using Caliburn.Micro.Unity.WinRT.ViewModels;
using PropertyChanged;
using Windows.UI.Popups;

namespace CaliburnDemo.ViewModels
{
    [ImplementPropertyChanged]
    public class SecondPageViewModel: ViewModelBase, IHaveState
    {
        public string Title { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }

        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Second Page";
        }

        public void GoBack()
        {
            this.navigationService.GoBack();
        }

        public override void LoadState(string Parameter, Dictionary<string, object> statePageState)
        {
            Property1 = (string)statePageState["Property1"];
            Property2 = (string)statePageState["Property2"];
        }

        public override void SaveState(Dictionary<string, object> statePageState, List<Type> knownTypes)
        {
            statePageState.Add("Property1", Property1);
            statePageState.Add("Property2", Property2);
        }
       
    }
}
