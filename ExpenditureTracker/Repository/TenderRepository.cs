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
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(Tender t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tender t)
        {
            throw new NotImplementedException();
        }
    }
}