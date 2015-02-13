using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ExpenditureTracker.Model;

namespace ExpenditureTracker
{
    public class ReceiptContext: DbContext
    {
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<PurchaseType> PurchaseTypes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Tender> Tenders { get; set; }
    }
}