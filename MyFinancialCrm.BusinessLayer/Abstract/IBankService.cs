using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.BusinessLayer.Abstract
{
    public interface IBankService: IGenericService<Banks>
    {
        decimal GetTotalBankBalance();
        decimal GetLastBankProcessAmount();
        DateTime? GetLastBankProcessDate();
        List<(string bankTitle, decimal balance)> GetBankChartData();
        List<(string billTitle, decimal amount)> GetBillChartData();
    }
}
