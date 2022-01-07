using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SouvenirApplication.Models;
using SQLite;

namespace SouvenirApplication.Data
{
    public class SouvenirShoppingListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public SouvenirShoppingListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SouvenirShopList>().Wait();
        }
        public Task<List<SouvenirShopList>> GetSouvenirShopListsAsync()
        {
            return _database.Table<SouvenirShopList>().ToListAsync();
        }
        public Task<SouvenirShopList> GetSouvenirShopListAsync(int id)
        {
            return _database.Table<SouvenirShopList>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveSouvenirShopListAsync(SouvenirShopList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteSouvenirShopListAsync(SouvenirShopList slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
