using DatabaseContext;

namespace Contracts;

public interface IVlsmResultRepository
{
    IEnumerable<Vlsmresult> GetAllResults(bool trackChanges);
    void CreateResults(Vlsmresult vlsmresult);
}