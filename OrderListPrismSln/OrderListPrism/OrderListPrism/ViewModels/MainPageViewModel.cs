using OrderListPrism.Services.Interfaces.DataBindingPrism.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;


namespace OrderListPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private IDatabase _database;

        private DelegateCommand _imageCommand;
        public DelegateCommand ImageCommand =>
            _imageCommand ?? (_imageCommand = new DelegateCommand(ExecuteImageClickedCommand));

        private DelegateCommand _viewOrdersCommand;
        public DelegateCommand ViewOrdersCommand =>
            _viewOrdersCommand ?? (_viewOrdersCommand = new DelegateCommand(ExecuteViewOrders));

        private void ExecuteViewOrders()
        {
            NavigationService.NavigateAsync("Page2");
        }

        private void ExecuteImageClickedCommand()
        {
            NavigationService.NavigateAsync("Page1");
        }

        public MainPageViewModel(INavigationService navigationService, IDatabase database)
            : base(navigationService)
        {
            Title = "Main Page";
            _database = database;
        }
    }
}