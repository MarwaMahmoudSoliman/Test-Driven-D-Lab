using Moq;
using StudentAPI.Models;
using StudentAPI.Repository;
using StudentAPI.Services;

namespace StudentAPITests
{
    [TestClass]
    public class StudentServiceTests
    {

        [TestMethod]
        public void GetById_ExistingId1_ReturnStudentWithId1()
        {
            var mockStudentRepo = new Mock<IStudentRepository>();
            var studentService = new StudentService(mockStudentRepo.Object);
            mockStudentRepo.Setup(m => m.GetById(1)).Returns(new Student(1));

            var student = studentService.GetById(1);

            Assert.AreEqual(1, student.Id);

        }
    }
}