using System.Threading.Tasks;

namespace CoreProjectAPI.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
