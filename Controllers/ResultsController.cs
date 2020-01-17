using Microsoft.AspNetCore.Mvc;
using Stream.API.Domain.Services;
using Stream.API.Domain.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;
using Stream.API.Resources;
using Stream.API.Extensions;

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
        //Handles posts api/results
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveResultResource resource)
        {
            if (!ModelState.IsValid)
		        return BadRequest(ModelState.GetErrorMessages());

            var res = _mapper.Map<SaveResultResource, Result>(resource);
            var result = await _resultsService.SaveAsync(res);

	if (!result.Success)
		return BadRequest(result.Message);

	var resResource = _mapper.Map<Result, ResultResource>(result.Result);
    //Returns ok message with input 
	return Ok(resResource);
        }
}
}