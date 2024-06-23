using SharedLibrary.Models.Entity;

namespace StudentManager.Server.Repository.Contract
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000);
        public Task<Student> GetByIdAsync(Guid id);

        public Task<Student> CreateStudentAsync(Student student);

        public Task<Student> UpdateStudentAsync(Student student);

        public Task DeleteByIdAsync(Guid id);

        public Task DeleteAllStudentsAsync();
    }
}
