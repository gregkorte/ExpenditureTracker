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
    }
}