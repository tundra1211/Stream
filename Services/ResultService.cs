using System.Collections.Generic;
using System.Threading.Tasks;
using Stream.API.Domain.Models;
using Stream.API.Domain.Services;
using Stream.API.Domain.Repositories;
using Stream.API.Domain.Services.Communication;
using System;

namespace Stream.API.Services
{
    public class ResultService : IResultsService
    {
        private readonly IResultRepository _resultRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ResultService(IResultRepository resultRepository, IUnitOfWork unitOfWork)
        {
            this._resultRepository = resultRepository;
            this._unitOfWork = unitOfWork;
        }
          public async Task<IEnumerable<Result>> ListAsync()
        {   //Returns a list of results asynchronously
            return await _resultRepository.ListAsync();
        }

        public async Task<SaveResultResponse> SaveAsync(Result result)
	{
		try
		{
			await _resultRepository.AddAsync(result);
			await _unitOfWork.CompleteAsync();
			
			return new SaveResultResponse(result);
		}
		catch (Exception ex)
		{
			// Do some logging stuff
			return new SaveResultResponse($"An error occurred when saving the category: {ex.Message}");
		}
	}
    }
}