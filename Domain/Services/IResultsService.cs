using System.Collections.Generic;
using System.Threading.Tasks;
using Stream.API.Domain.Models;
using Stream.API.Domain.Services.Communication;

namespace Stream.API.Domain.Services
{
    public interface IResultsService
    {  
         Task<IEnumerable<Result>> ListAsync();
         Task<SaveResultResponse> SaveAsync(Result result);
    }
}