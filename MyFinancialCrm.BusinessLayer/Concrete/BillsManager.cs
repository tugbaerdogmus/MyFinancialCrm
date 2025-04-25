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
    public class BillsManager : IBillsService
    {
        private readonly IBillsDal _billsDal;
        public BillsManager(IBillsDal billsDal)
        {
            _billsDal = billsDal;
        }
        public void TDelete(int id)
        {
            var entity = _billsDal.GetByID(id);
            if (entity != null)
            {
                _billsDal.Delete(entity);
            }
        }

        public List<Bills> TGetAll()
        {
            return _billsDal.GetAll();
        }

        public Bills TGetById(int id)
        {
            return _billsDal.GetByID(id);
        }

        public void TInsert(Bills entity)
        {
            _billsDal.Insert(entity);
        }

        public void TUpdate(Bills entity)
        {
            var existing = _billsDal.GetByID(entity.BillId);
            if (existing != null)
            {
                existing.BillTitle = entity.BillTitle;
                existing.BillPeriod = entity.BillPeriod;
                existing.BillAmount = entity.BillAmount;
                _billsDal.Update(existing);
            }
        }
    }
}
