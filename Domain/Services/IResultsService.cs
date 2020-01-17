using System.Collections.Generic;
using System.Threading.Tasks;
using Stream.API.Domain.Models;

namespace Stream.API.Domain.Services
{
    public interface IResultsService
    {   //Returns a list of results asynchronously
         Task<IEnumerable<Result>> ListAsync();
    }
}