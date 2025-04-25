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
    public class EfBillsDal: GenericRepository<Bills>, IBillsDal
    {
    }
}
