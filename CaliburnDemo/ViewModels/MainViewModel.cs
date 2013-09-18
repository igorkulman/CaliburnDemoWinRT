using Caliburn.Micro;
using Caliburn.Micro.Unity.WinRT.ViewModels;
using CaliburnDemo.Data;
using CaliburnDemo.Servcies;
using PropertyChanged;
using Windows.UI.Popups;

namespace CaliburnDemo.ViewModels
{
    [ImplementPropertyChanged]
    public class MainViewModel: ViewModelBase
    {
        public string Title { get; set; }
        public IObservableCollection<Product> Products { get; private set; }
        private readonly IProductService _productService;

        public MainViewModel(INavigationService navigationService, IProductService productService) : base(navigationService)
        {
            _productService = productService;
            Title = "Caliburn Demo";
            Products = new BindableCollection<Product>(_productService.GetAll());
        }

        public void GoToSecondPage()
        {
            navigationService.UriFor<SecondPageViewModel>().WithParam(l=>l.Title, "Navigated from MainViewModel").Navigate();
        }
    }
}
