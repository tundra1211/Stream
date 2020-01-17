using System.Collections.Generic;
using System.Threading.Tasks;
using Stream.API.Domain.Models;

namespace Stream.API.Domain.Services
{
    public interface IStudentService
    {
         Task<IEnumerable<Student>> ListAsync();
    }
}