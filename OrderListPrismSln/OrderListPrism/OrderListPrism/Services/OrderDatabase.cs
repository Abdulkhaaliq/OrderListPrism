using OrderListPrism.Models;
using OrderListPrism.Services.Interfaces.DataBindingPrism.Services.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderListdatabase
{
    public class OrderListDatabase  : IDatabase
    {
        readonly SQLiteAsyncConnection database;

        public OrderListDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Info>().Wait();
        }
        public Task<List<Info>> GetItemsAsync()

        {
            return database.Table<Info>().ToListAsync();
        }

        public Task<List<Info>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Info>("SELECT * FROM [Info]");
        }
        public async Task<Info> GetItemAsync(int ID)
        {
            int count = await database.Table<Info>().CountAsync();
            var latest = await database.Table<Info>().Where(x => x.ID == count).FirstOrDefaultAsync();

            return latest;
        }
        public Task<int> SaveItemAsync(Info item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public async void DeleteItemsAsync(Info item)
        {
           // await _database.DeleteAsync(item);
        }

        public Task<Info> GetItemAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Info product)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Info product)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveItemAsync()
        {
            throw new NotImplementedException();
        }

        

        public Task<int> DeleteItemsAsync(string v, Info product)
        {
            throw new NotImplementedException();
        }
    }
}
