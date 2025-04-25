using MyFinancialCrm.BusinessLayer.Abstract;
using MyFinancialCrm.DataAccessLayer.Abstract;
using MyFinancialCrm.DataAccessLayer.Context;
using MyFinancialCrm.EntityLayer.Models;
using MyFinancialCrm.BusinessLayer.Abstract;
using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.BusinessLayer.Concrete
{
    public class BankProcessManager : IBankProcessService
    {
        private readonly IBankProcessDal _processDal;
        public BankProcessManager(IBankProcessDal processDal)
        {
            _processDal = processDal;
        }

        public void TDelete(int id)
        {
            var entity = _processDal.GetByID(id);
            if (entity != null)
            {
                _processDal.Delete(entity);
            }
        }

        public List<BankProcesses> TGetAll()
        {
            return _processDal.GetAll();
        }

        public BankProcesses TGetById(int id)
        {
            return _processDal.GetByID(id);
        }

        public void TInsert(BankProcesses entity)
        {
            _processDal.Insert(entity); 
          
        }

        public void TUpdate(BankProcesses entity)
        {
            var existing = _processDal.GetByID(entity.BankProcessId);
            if (existing != null)
            {
                existing.ProcessDate = entity.ProcessDate;
                existing.ProcessType = entity.ProcessType;
                existing.Amount = entity.Amount;
                existing.Description = entity.Description;
                //  existing.Banks = entity.Banks;
                _processDal.Update(existing);
            }
        }
        //public List<BankProcesses> GetProcessListWithBank() => _processDal.GetProcessListWithBank();
        public List<BankProcesses> GetProcessListWithBank()
        {
            return _processDal.GetProcessListWithBank()
                       .OrderByDescending(x => x.BankProcessId)
                       .ToList();
        }
    }
}
