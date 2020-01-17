using System.Threading.Tasks;

namespace Stream.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}