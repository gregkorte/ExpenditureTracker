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
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(PurchaseType p)
        {
            throw new NotImplementedException();
        }

        public void Delete(PurchaseType p)
        {
            throw new NotImplementedException();
        }
    }
}