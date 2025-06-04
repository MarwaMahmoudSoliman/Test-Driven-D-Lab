using StudentAPI.Models;

namespace StudentAPI.Repository
{
    public interface IStudentRepository
    {
        Student GetById(int id);
    }
}
