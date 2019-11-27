using OrderListPrism.Models;
using OrderListPrism.Services.Interfaces.DataBindingPrism.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderListPrism.ViewModels
{
    public class Page2ViewModel : ViewModelBase
    {

            private IDatabase _database;
        public List<Info> Orders { get; set; }



        private DelegateCommand _mappingCommand;
        public DelegateCommand MappingCommand =>
            _mappingCommand ?? (_mappingCommand = new DelegateCommand(ExecuteMappingCommandAsync));

        private DelegateCommand _onDelete;
        public DelegateCommand OndeleteCommand =>
            _onDelete ?? (_onDelete = new DelegateCommand(ExecuteOndeleteCommandAsync));


        private void ExecuteMappingCommandAsync()
        {
            
        }


        private void ExecuteOndeleteCommandAsync()
        {
            
        }

        public Page2ViewModel(INavigationService navigationService, IDatabase database)
        : base(navigationService)
        {
            Title = "Orders Page";
            _database = database;
        }
    }   
}
