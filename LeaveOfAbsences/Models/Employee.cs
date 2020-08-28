using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveOfAbsences.Models
{
    [Table("Employees")]
    public class Employee
    {
        public Employee()
        {
            this.LeaveOfAbsences = new HashSet<LeaveOfAbsence>();
        }
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<LeaveOfAbsence> LeaveOfAbsences { get; set; }
    }
}
