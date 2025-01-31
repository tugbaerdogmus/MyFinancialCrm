using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialCrm.EntityLayer.Context
{
    public class FinansalCrmContext : DbContext
    {
        public FinansalCrmContext() : base("name=FinancialCrmDbEntities") { }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<BankProcesses> BankProcesses { get; set; }
        public DbSet<Banks> Banks { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Spendings> Spendings { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
