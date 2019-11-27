using OrderListPrism.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderListPrism.Services.Interfaces
{
    namespace DataBindingPrism.Services.Interfaces
    {
        public interface IDatabase
        {
            Task<List<Info>> GetItemsAsync();
            Task<int> SaveItemAsync();
            Task<int> DeleteItemsAsync(string v, Info product);
            Task<int> UpdateAsync(Info product);
            
        }
    }
}