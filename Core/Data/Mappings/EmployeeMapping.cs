using Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Mappings
{
    public class EmployeeMapping : EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            HasKey(x => x.EmployeeID);
            Property(x => x.FirstName).IsRequired().HasMaxLength(255);
            Property(x => x.LastName).IsRequired().HasMaxLength(255);
            Property(x => x.Address).HasMaxLength(350);
            Property(x => x.Designation).HasMaxLength(150);
        }
    }
}
