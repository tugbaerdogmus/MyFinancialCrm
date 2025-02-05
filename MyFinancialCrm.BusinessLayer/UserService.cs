using MyFinancialCrm.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.BusinessLayer
{
    public class UserService
    {
        public bool ValidateUser(string username, string password)
        {
            using (var db = new FinansalCrmContext())
            {
                return db.Users.Any(u => u.Username == username && u.Password == password);
            }
        }
    }
}
