using System.Collections.Generic;
using System.Threading.Tasks;
using Stream.API.Domain.Models;

namespace Stream.API.Domain.Repositories
{
    public interface IStudentRepository
    {
         Task<IEnumerable<Student>> ListAsync();
    }
}