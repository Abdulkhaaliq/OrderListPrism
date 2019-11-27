using OrderListPrism.Models;
using OrderListPrism.Services.Interfaces.DataBindingPrism.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OrderListPrism.ViewModels
{
    public class Page1ViewModel : ViewModelBase
    {      
             private IDatabase _database;

        private DelegateCommand _fieldName;
        public DelegateCommand CommandName =>
            _fieldName ?? (_fieldName = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {

        }


        public Page1ViewModel(INavigationService navigationService, IDatabase database)
      : base(navigationService)
        {
            Title = "Order Page";
            _database = database;
        }
    }
}
  

