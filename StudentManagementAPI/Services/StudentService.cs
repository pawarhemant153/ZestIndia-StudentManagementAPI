using StudentManagementAPI.Models;
using StudentManagementAPI.Repository;

namespace StudentManagementAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetAll()
        {
            return _repo.GetAll();
        }
        public Student GetById(int id)
        {
            return _repo.GetById(id);
        }
        public void Add(Student st)
        {
            if (st.Age < 1)
                throw new Exception("Invalid Age");

            _repo.Add(st);
        }
        public void Update(Student st)
        {
            _repo.Update(st);
        }
        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
