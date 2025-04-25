using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.BusinessLayer.Abstract
{
    public interface ISpendingService : IGenericService<Spendings>
    {
        List<Spendings> GetSpendingListWithCategory();

    }
}
