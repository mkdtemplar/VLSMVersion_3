using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContext;

namespace Contracts
{
    public interface IVlsmResultRepository
    {
        IEnumerable<Vlsmresult> GetAllResults(bool trackChanges);
        void CreateResults(Vlsmresult vlsmresult);
    }
}
