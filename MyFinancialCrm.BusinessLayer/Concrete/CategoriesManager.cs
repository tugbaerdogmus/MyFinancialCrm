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
    public class CategoriesManager : ICategoryService
    {
        private readonly ICategoriesDal _catDal;
        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _catDal = categoriesDal;
        }
        public void TDelete(int id)
        {
            //_catDal.Delete(entity);
            var entity = _catDal.GetByID(id);
            if (entity != null)
            {
                _catDal.Delete(entity);
            }
        }

        public List<Categories> TGetAll()
        {
            return _catDal.GetAll();
        }

        public Categories TGetById(int id)
        {
        return _catDal.GetByID(id);
        }

        public void TInsert(Categories entity)
        {
            _catDal.Insert(entity);
        }

        public void TUpdate(Categories entity)
        {
            var existing = _catDal.GetByID(entity.CategoyId);
            if (existing != null)
            {
                existing.CatogoryName = entity.CatogoryName;
                _catDal.Update(existing);
            }
        }
        public List<Categories> GetAllWithDefault()
        {
            var categories = _catDal.GetAll().ToList();

            categories.Insert(0, new Categories
            {
                CategoyId = 0,
                CatogoryName = "Tümü"
            });

            return categories;
        }
    }
}
