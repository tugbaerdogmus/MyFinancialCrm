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
    public class UsersManager:IUsersService
    {
        private readonly IUsersDal _usersDal;
        public UsersManager(IUsersDal uSersDal)
        {
            _usersDal = uSersDal;
        }

        public void TDelete(Users entity)
        {
            _usersDal.Delete(entity);
        }

        public List<Users> TGetAll()
        {
            return _usersDal.GetAll();
        }

        public Users TGetById(int id)
        {
            return _usersDal.GetByID(id);
        }

        public void TInsert(Users entity)
        {
            //şartlar eklenebilir
            throw new NotImplementedException();
        }

        public void TUpdate(Users entity)
        {
            if(entity.UserId != 0)
            {
                _usersDal.Update(entity);
            }
            else
            {
                //hata mesajı
            }
        }
        public bool Login(string username, string password)
        {
            using (var db = new FinansalCrmContext())
            {
                return db.Users.Any(u => u.Username == username && u.Password == password);
            }
        }
    }
}
