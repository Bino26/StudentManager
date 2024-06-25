using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models.Entity;
using StudentManager.Server.Data;
using StudentManager.Server.Repository.Contract;

namespace StudentManager.Server.Repository.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext studentDbContext;

        public StudentRepository(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext ?? throw new ArgumentNullException(nameof(studentDbContext));
        }

        public async Task<Student> CreateStudentAsync(Student student)
        {
            try
            {
                if (student is null)
                {
                    throw new ArgumentNullException("Field is empty");
                }

                await studentDbContext.Students.AddAsync(student);
                await studentDbContext.SaveChangesAsync();
                return student;

            }
            catch (Exception)
            {
                throw new Exception("Failed to create student");

            }
        }

        public async Task DeleteAllStudentsAsync()
        {
            try
            {
                var students = await studentDbContext.Students.ToListAsync();
                studentDbContext.Students.RemoveRange(students);


            }
            catch (Exception)
            {
                throw new Exception("Failed to delete all students");

            }
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            try
            {
                var student = await studentDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
                if (student != null)
                {
                    studentDbContext.Students.Remove(student);
                    await studentDbContext.SaveChangesAsync();

                }
                else
                {
                    throw new ArgumentNullException("Student not found");
                }

            }
            catch (Exception)
            {
                throw new Exception("Failed to delete student ");

            }



        }

        public async Task<List<Student>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            try
            {
                var students = studentDbContext.Students.AsQueryable();


                //filtering

                if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
                {
                    if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                    {
                        students = students.Where(x => x.Name.Contains(filterQuery));
                    }
                }
                // Sorting 
                if (string.IsNullOrWhiteSpace(sortBy) == false)
                {
                    if (sortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                    {
                        students = isAscending ? students.OrderBy(x => x.Name) : students.OrderByDescending(x => x.Name);
                    }
                    else if (sortBy.Equals("Class", StringComparison.OrdinalIgnoreCase))
                    {
                        students = isAscending ? students.OrderBy(x => x.Class) : students.OrderByDescending(x => x.Class);
                    }
                }
                // Pagination
                var skipResults = (pageNumber - 1) * pageSize;

                return await students.Skip(skipResults).Take(pageSize).ToListAsync();

            }
            catch (Exception)
            {
                throw new Exception("Failed to get students");
            }
        }

        public async Task<Student> GetByIdAsync(Guid id)
        {
            try
            {
                var student = await studentDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
                if (student != null)
                {
                    return student;
                }
                else
                {
                    throw new ArgumentNullException("Student not found ");
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to get student");

            }


        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            try
            {
                var existingStudent = await studentDbContext.Students.FirstOrDefaultAsync(x => x.Id == student.Id);
                if (existingStudent != null)
                {
                    existingStudent.Name = student.Name;
                    existingStudent.Email = student.Email;
                    existingStudent.Class = student.Class;

                    studentDbContext.Students.Update(existingStudent);
                    await studentDbContext.SaveChangesAsync();

                    return existingStudent;
                }
                else
                {
                    throw new ArgumentNullException("Student not found");
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to update student");

            }

        }
    }
}
