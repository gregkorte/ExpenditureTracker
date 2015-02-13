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
            return _dbContext.Receipts.Count<Receipt>();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Receipts.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public void Add(Receipt r)
        {
            _dbContext.Receipts.Add(r);
            _dbContext.SaveChanges();
        }

        public void Delete(Receipt r)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Receipt> All()
        {
            var qu = from Receipt in _dbContext.Receipts select Receipt;
            return qu.ToList<Receipt>();
        }
    }
}
