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
            return _dbContext.Stores.Count<Store>();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Stores.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public void Add(Store s)
        {
            _dbContext.Stores.Add(s);
            _dbContext.SaveChanges();
        }

        public void Delete(Store s)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Store> All()
        {
            var qu = from Store in _dbContext.Stores select Store;
            return qu.ToList<Store>();
        }
    }
}