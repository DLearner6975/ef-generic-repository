using Core.Data.Entities;
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
            this.Configuration.LazyLoadingEnabled = true;
        }

        //=================  For Migration Purpose. Hide it for production use ============
        public DbSet<Employee> Employees { get; set; }

        //=================  For Migration Purpose. Hide it for production use ============
        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

    }
}
