using LeaveOfAbsences.Core;
using LeaveOfAbsences.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveOfAbsences.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;
        private RepositoryBase<Employee> _employeeRepository;
        private RepositoryBase<AbsenceType> _absenceTypeRepository;
        private RepositoryBase<LeaveOfAbsence> _LeaveOfAbsenceRepository;
        public UnitOfWork(DbContext context)
        {
            this._context = context;
        }

        public RepositoryBase<Employee> Employees
        { 
            get 
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new RepositoryBase<Employee>(_context);
                }
                return _employeeRepository;
            }
        }
        public RepositoryBase<AbsenceType> AbsenceTypes
        {
            get
            {
                if (_absenceTypeRepository == null)
                {
                    _absenceTypeRepository = new RepositoryBase<AbsenceType>(_context);
                }
                return _absenceTypeRepository;
            }
        }
        public RepositoryBase<LeaveOfAbsence> LeaveOfAbsences
        {
            get
            {
                if (_absenceTypeRepository == null)
                {
                    _LeaveOfAbsenceRepository = new RepositoryBase<LeaveOfAbsence>(_context);
                }
                return _LeaveOfAbsenceRepository;
            }
        } 
      
        public void Dispose()
        {
            this._context.Dispose();
        }

        public void Save()
        {
            this._context.SaveChanges();
        }
    }
}
