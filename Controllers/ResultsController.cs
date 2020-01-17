using Microsoft.AspNetCore.Mvc;
using Stream.API.Domain.Services;
using Stream.API.Domain.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Stream.API.Controllers
{
    [Route("/api/[controller]")]
    public class ResultsController : Controller
    {
        private readonly IResultsService _resultsService;

        public ResultsController(IResultsService resultsService)
        {
        _resultsService=resultsService;
        }
        //Handles get requests for api/Results
        [HttpGet]
        public async Task<IEnumerable<Result>> GetAllAsync()
        {
            var results= await _resultsService.ListAsync();
            return results;
        }
}
}