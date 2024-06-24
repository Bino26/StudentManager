using SharedLibrary.Models.Entity;
using System.Net.Http.Json;

namespace StudentManager.Client.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient httpClient;

        public StudentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Student?> GetStudentById(Guid id)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<Student>($"api/student/{id}");

            }
            catch (Exception)
            {
                throw new Exception("Failed to get student");
            }



        }
        public async Task<List<Student>> GetStudents()
        {
            try
            {
                return await httpClient.GetFromJsonAsync<List<Student>>("api/student/list");

            }

            catch (Exception)
            {
                throw new Exception("Failed to get students");
            }
        }

        public async Task<Student> CreateStudent(Student student)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync<Student>("api/student/createstudent", student);
                if (response.IsSuccessStatusCode)
                {

                    Student createdStudent = await response.Content.ReadFromJsonAsync<Student>();
                    return createdStudent;
                }
                else
                {
                    throw new Exception("Failed to create student: " + response.ReasonPhrase);
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to create student");
            }



        }
        public async Task DeleteStudent(Guid id)
        {
            try
            {
                await httpClient.DeleteAsync($"api/student/{id}");

            }
            catch (Exception)
            {
                throw new Exception("Failed to create student");
            }



        }

        public async Task<Student> UpdateStudent(Student student)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/student", student);
                if (response.IsSuccessStatusCode)
                {

                    Student updateStudent = await response.Content.ReadFromJsonAsync<Student>();
                    return updateStudent;
                }
                else
                {
                    throw new Exception("Failed to update student: " + response.ReasonPhrase);
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to create student");
            }

        }
    }
}
