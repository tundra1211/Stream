using System.Collections.Generic;
using System.Threading.Tasks;
using Stream.API.Domain.Models;
using Stream.API.Domain.Repositories;
using Stream.API.Domain.Services;

namespace Stream.API.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
    
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>> ListAsync()
        {
            return await _studentRepository.ListAsync();
        }
    }
}