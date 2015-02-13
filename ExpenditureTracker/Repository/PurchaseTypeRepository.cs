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
    public class PurchaseTypeRepository : IPurchaseTypeRepository
    {
        private ReceiptContext _dbContext;

        public PurchaseTypeRepository()
        {
            _dbContext = new ReceiptContext();
            _dbContext.PurchaseTypes.Load();
        }

        public ReceiptContext Context()
        {
            return _dbContext;
        }

        public DbSet<PurchaseType> GetDbSet()
        {
            return _dbContext.PurchaseTypes;
        }

        public int GetCount()
        {
            return _dbContext.PurchaseTypes.Count<PurchaseType>();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.PurchaseTypes.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public void Add(PurchaseType p)
        {
            _dbContext.PurchaseTypes.Add(p);
            _dbContext.SaveChanges();
        }

        public void Delete(PurchaseType p)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PurchaseType> All()
        {
            var qu = from PurchaseType in _dbContext.PurchaseTypes select PurchaseType;
            return qu.ToList<PurchaseType>();
        }
    }
}