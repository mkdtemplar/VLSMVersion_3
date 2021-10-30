using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DatabaseContext;

namespace Repository
{
    public class VlsmRepository : RepositoryBase<Vlsmresult>, IVlsmResultRepository
    {
        public VlsmRepository(VlsmDb repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Vlsmresult> GetAllResults(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public void CreateResults(Vlsmresult vlsmresult) => CreateResults(vlsmresult);
    }
}
