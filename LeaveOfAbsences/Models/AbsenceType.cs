using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveOfAbsences.Models
{
    [Table("AbsenceTypes")]
    public class AbsenceType
    {
        public AbsenceType()
        {
            this.LeaveOfAbsences = new HashSet<LeaveOfAbsence>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<LeaveOfAbsence> LeaveOfAbsences { get; set; }
    }
}