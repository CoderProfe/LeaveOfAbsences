using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveOfAbsences.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
