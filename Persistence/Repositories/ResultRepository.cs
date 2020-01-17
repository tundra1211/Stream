using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stream.API.Domain.Models;
using Stream.API.Domain.Repositories;
using Stream.API.Persistence.Contexts;


namespace Stream.API.Persistence.Repositories
{
    public class ResultRepository : BaseRepository, IResultRepository
    {
        public ResultRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Result>> ListAsync()
        {
            return await _context.Results.ToListAsync();
        }

        public async Task AddAsync(Result result)
	{
		await _context.Results.AddAsync(result);
	}
    }
}