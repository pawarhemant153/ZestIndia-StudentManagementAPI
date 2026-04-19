using Xunit;
using Moq;
using StudentManagementAPI.Models;
using StudentManagementAPI.Repository;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Tests
{
    public class StudentServiceTests
    {
        [Fact]
        public void Add_InvalidAge_ShouldThrowException()
        {
            // Arrange
            var repoMock = new Mock<IStudentRepository>();
            var service = new StudentService(repoMock.Object);

            var student = new Student
            {
                Name = "Hemant",
                Age = 0
            };

            // Act & Assert
            Assert.Throws<Exception>(() => service.Add(student));
        }
    }
}