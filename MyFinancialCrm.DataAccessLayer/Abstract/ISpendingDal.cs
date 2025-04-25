using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.DataAccessLayer.Abstract
{
    public interface ISpendingDal: IGenericDal<Spendings>
    {
        List<Spendings> GetSpendingListWithCategory();

    }
}
