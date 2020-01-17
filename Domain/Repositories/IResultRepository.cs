using System.Collections.Generic;
using System.Threading.Tasks;
using Stream.API.Domain.Models;

namespace Stream.API.Domain.Repositories
{
    public interface IResultRepository
    {
         Task<IEnumerable<Result>> ListAsync();
    }
}