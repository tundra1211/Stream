using System.Collections.Generic;
using System.Threading.Tasks;
using Stream.API.Domain.Models;
using Stream.API.Domain.Services;
using Stream.API.Domain.Repositories;

namespace Stream.API.Services
{
    public class ResultService : IResultsService
    {
        private readonly IResultRepository _resultRepository;
        public ResultService(IResultRepository resultRepository)
        {
            this._resultRepository = resultRepository;
        }
          public async Task<IEnumerable<Result>> ListAsync()
        {   //Returns a list of results asynchronously
            return await _resultRepository.ListAsync();
        }
    }
}