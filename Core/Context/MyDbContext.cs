using Core.Data.Entities;
using Core.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(null);
            this.Configuration.LazyLoadingEnabled = true;
        }

        
        public DbSet<Employee> Employees { get; set; }

        
        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMapping());  
        }

    }
}
