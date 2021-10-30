using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DatabaseContext;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private VlsmDb _repository_Context;
        private IVlsmResultRepository _vlsmResultRepository;

        public RepositoryManager(VlsmDb repositoryContext)
        {
            _repository_Context = repositoryContext;
        }

        public IVlsmResultRepository Vlsm
        {
            get
            {
                if (_vlsmResultRepository == null)
                {
                    _vlsmResultRepository = new VlsmRepository(_repository_Context);
                }

                return _vlsmResultRepository;
            }
        }
        public void Save() => _repository_Context.SaveChanges();
    }
}
