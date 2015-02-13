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
    public class ReceiptRepository : IReceiptRepository
    {
        private ReceiptContext _dbContext;

        public ReceiptRepository()
        {
            _dbContext = new ReceiptContext();
            _dbContext.Receipts.Load();
        }

        public ReceiptContext Context()
        {
            return _dbContext;
        }

        public DbSet<Receipt> GetDbSet()
        {
            return _dbContext.Receipts;
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(Receipt r)
        {
            throw new NotImplementedException();
        }

        public void Delete(Receipt r)
        {
            throw new NotImplementedException();
        }
    }
}
