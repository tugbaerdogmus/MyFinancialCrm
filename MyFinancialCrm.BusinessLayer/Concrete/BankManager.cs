using MyFinancialCrm.BusinessLayer.Abstract;
using MyFinancialCrm.DataAccessLayer.Abstract;
using MyFinancialCrm.DataAccessLayer.Context;
using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.BusinessLayer.Concrete
{
    public class BankManager : IBankService
    {
        private readonly IBankDal _bankDal;
        private readonly FinancialCrmDbEntities _context;

        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
            _context = new FinancialCrmDbEntities();

        }
        public void TDelete(int id)
        {
            var entity = _bankDal.GetByID(id);
            if (entity != null)
            {
                _bankDal.Delete(entity);
            }
        }

        public List<Banks> TGetAll()
        {
            return _bankDal.GetAll();
        }

        public Banks TGetById(int id)
        {
            return _bankDal.GetByID(id);
        }

        public void TInsert(Banks entity)
        {
            _bankDal.Insert(entity);
        }

        public void TUpdate(Banks entity)
        {
            var existing = _bankDal.GetByID(entity.BankaId);
            if (existing != null)
            {
                existing.BankTitle = entity.BankTitle;
                existing.BankBalance = entity.BankBalance;
                existing.BankProcesses = entity.BankProcesses;
                existing.BankAccountNumber = entity.BankAccountNumber;

                _bankDal.Update(existing);
            }
        }

        public decimal GetTotalBankBalance()
        {
            return _context.Banks.Sum(x => x.BankBalance) ?? 0;
        }

        public decimal GetLastBankProcessAmount()
        {
            return _context.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Select(x => x.Amount)
                .FirstOrDefault() ?? 0;
        }

        public DateTime? GetLastBankProcessDate()
        {
            return _context.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Select(x => x.ProcessDate)
                .FirstOrDefault();
        }

        public List<(string bankTitle, decimal balance)> GetBankChartData()
        {
            return _context.Banks
                .Select(x => new { x.BankTitle, x.BankBalance })
                .ToList()
                .Select(x => (x.BankTitle, x.BankBalance ?? 0))
                .ToList();
        }

        public List<(string billTitle, decimal amount)> GetBillChartData()
        {
            return _context.Bills
                .Select(x => new { x.BillTitle, x.BillAmount })
                .ToList()
                .Select(x => (x.BillTitle, x.BillAmount ?? 0))
                .ToList();
        }
        public List<Banks> TGetBankL(string bankTitle)
        {
            var list = _context.Banks
         .Where(x => x.BankTitle == bankTitle)
         .Select(x => new
         {
             x.BankTitle,
             x.BankBalance
         })
         .ToList();

            return list.Select(x => new Banks
            {
                BankTitle = x.BankTitle,
                BankBalance = x.BankBalance ?? 0
            }).ToList();
        }

    }
}
