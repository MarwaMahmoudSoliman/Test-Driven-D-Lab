
using StudentAPI.Models;
using StudentAPI.Repository;

namespace StudentAPI.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}
