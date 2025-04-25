using MyFinancialCrm.DataAccessLayer.Abstract;
using MyFinancialCrm.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        FinansalCrmContext context = new FinansalCrmContext();
        private readonly DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }
        public T GetByID(int id)
        {
            return _object.Find(id);
        }
        public void Delete(T entity)
        {
            //hata varsa kontrol edilecek
            var deletedEntity=context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();

        }

        public void Insert(T entity)
        {
            var addedEntity=context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updateEntity=context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
