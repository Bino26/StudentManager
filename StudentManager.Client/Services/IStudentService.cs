using SharedLibrary.Models.Entity;

namespace StudentManager.Client.Services
{
    public interface IStudentService
    {
        public Task<Student?> GetStudentById(Guid id);
        public Task<List<Student>> GetStudents();
        public Task<Student> CreateStudent(Student student);
        public Task<Student> UpdateStudent(Student student);
        public Task DeleteStudent(Guid id);
    }
}
