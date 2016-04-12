using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Entities
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter first name.")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter last name.")]
        public string LastName { get; set; }

        [StringLength(355)]
        public string Address { get; set; }

        public int Age { get; set; }

        [StringLength(150)]
        public string Designation { get; set; }

        public double Salary { get; set; }

    }
}
