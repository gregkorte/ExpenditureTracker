using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenditureTracker;
using System.Data.Entity;
using ExpenditureTracker.Model;

namespace ExpenditureTracker.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private ReceiptContext _dbContext;

        public StoreRepository()
        {
            _dbContext = new ReceiptContext();
            _dbContext.Stores.Load();
        }

        public ReceiptContext Context()
        {
            return _dbContext;
        }

        public DbSet<Store> GetDbSet()
        {
            return _dbContext.Stores;
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(Store s)
        {
            throw new NotImplementedException();
        }

        public void Delete(Store s)
        {
            throw new NotImplementedException();
        }
    }
}