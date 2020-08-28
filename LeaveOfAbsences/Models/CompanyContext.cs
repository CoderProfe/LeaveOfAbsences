using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveOfAbsences.Models
{
    public class CompanyContext: DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AbsenceType> AbsenceTypes { get; set; }
        public DbSet<LeaveOfAbsence> LeaveOfAbsences { get; set; }
    }
}
