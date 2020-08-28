using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveOfAbsences.Models
{
    [Table("LeaveOfAbsences")]
    public class LeaveOfAbsence
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int AbsenceTypeId { get; set; }
        public AbsenceType AbsenceType { get; set; }
        public DateTime AbsenceDate { get; set; }

    }
}
