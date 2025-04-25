using MyFinancialCrm.DataAccessLayer.Abstract;
using MyFinancialCrm.DataAccessLayer.Repositories;
using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.DataAccessLayer.EntityFramework
{
    public class EfSpendingDal: GenericRepository<Spendings>, ISpendingDal
    {
        public List<Spendings> GetSpendingListWithCategory()
        {
            using (var context = new FinancialCrmDbEntities())
            {
                return context.Spendings.Include("Categories").ToList();
            }
        }
    }
}
