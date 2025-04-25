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
    public class SpendingManager : ISpendingService
    {
        private readonly ISpendingDal _spendingDal;

        public SpendingManager(ISpendingDal spendingDal)
        {
            _spendingDal = spendingDal;
        }
        public List<Spendings> GetSpendingListWithCategory() => _spendingDal.GetSpendingListWithCategory();


        public void TDelete(int id)
        {
            var entity = _spendingDal.GetByID(id);
            if (entity != null)
            {
                _spendingDal.Delete(entity);
            }
        }

        public List<Spendings> TGetAll()
        {
            return _spendingDal.GetAll();
        }

        public Spendings TGetById(int id)
        {
            return _spendingDal.GetByID(id);
        }

        public void TInsert(Spendings entity)
        {
            _spendingDal.Insert(entity);
        }

        public void TUpdate(Spendings entity)
        {
            _spendingDal.Update(entity);
        }
    }
}
