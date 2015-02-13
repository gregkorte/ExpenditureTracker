using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ExpenditureTracker.Model;

namespace ExpenditureTracker.Repository
{
    public interface IPurchaseTypeRepository
    {
        int GetCount();
        void Add(PurchaseType p); //
        void Delete(PurchaseType p); //
        void Clear(); //
        //IEnumerable<Event> PastEvents(); //
        //int CalculateMonth(Event E); //
        //IEnumerable<Event> All(); //
        //Event GetById(int id); //
        //Event GetByDate(string date); //
        //IQueryable<Event> SearchFor(Expression<Func<Event, bool>> predicate);
    }
}
