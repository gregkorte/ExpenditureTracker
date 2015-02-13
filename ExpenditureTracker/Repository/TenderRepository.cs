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
    public class TenderRepository : ITenderRepository
    {
        private ReceiptContext _dbContext;

        public TenderRepository()
        {
            _dbContext = new ReceiptContext();
            _dbContext.Tenders.Load();
        }

        public ReceiptContext Context()
        {
            return _dbContext;
        }

        public DbSet<Tender> GetDbSet()
        {
            return _dbContext.Tenders;
        }

        public int GetCount()
        {
            return _dbContext.Tenders.Count<Tender>();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Tenders.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public void Add(Tender t)
        {
            _dbContext.Tenders.Add(t);
            _dbContext.SaveChanges();
        }

        public void Delete(Tender t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tender> All()
        {
            var qu = from Tender in _dbContext.Tenders select Tender;
            return qu.ToList<Tender>();
        }
    }
}