namespace Contracts;

public interface IRepositoryManager
{
    IVlsmResultRepository Vlsm { get; }
    void Save();
}