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
            _dbContext.Receipts.Remove(r);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Receipt> All()
        {
            var qu = from Receipt in _dbContext.Receipts select Receipt;
            return qu.ToList<Receipt>();
        }

        public int GetId(string Date, string StoreName, string PurchaseType, double SalesTax, double SalesTotal, string TenderType)
        {
            var get = from Receipt in _dbContext.Receipts
                        where (Receipt.Date == Date &&
                               Receipt.StoreName == StoreName &&
                               Receipt.PurchaseType == PurchaseType &&
                               Receipt.SalesTax == SalesTax &&
                               Receipt.SalesTotal == SalesTotal &&
                               Receipt.TenderType == TenderType)
                        select Receipt;
            return get.First<Model.Receipt>().ReceiptId;
        }

        public Model.Receipt GetById(int id)
        {
            var query = from r in _dbContext.Receipts
                     where r.ReceiptId == id
                     select r;
            return query.First<Model.Receipt>();
        }
    }
}
