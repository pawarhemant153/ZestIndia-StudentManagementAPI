using StudentManagementAPI.Data;
using StudentManagementAPI.Models;
namespace StudentManagementAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentManagmentDbContext _context;

        public StudentRepository(StudentManagmentDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }
        public Student GetById(int id)
        {
            Student st = _context.Students.FirstOrDefault(x => x.Id == id);
            return st;
        }
        public void Add(Student st)
        {
            _context.Students.Add(st);
            _context.SaveChanges();
        }
        public void Update(Student st)
        {
            _context.Students.Update(st);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var data= _context.Students.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                _context.Students.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
