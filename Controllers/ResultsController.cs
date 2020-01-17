using Microsoft.AspNetCore.Mvc;
using Stream.API.Domain.Services;
using Stream.API.Domain.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;
using Stream.API.Resources;

namespace Stream.API.Controllers
{
    [Route("/api/[controller]")]
    public class ResultsController : Controller
    {
        private readonly IResultsService _resultsService;
        private readonly IMapper _mapper;

        public ResultsController(IResultsService resultsService, IMapper mapper)
        {
        _resultsService=resultsService;
        _mapper=mapper;
        }
        //Handles get requests for api/Results
        [HttpGet]
        public async Task<IEnumerable<ResultResource>> GetAllAsync()
        {
            var results= await _resultsService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Result>, IEnumerable<ResultResource>>(results);
            return resources;
        }
}
}