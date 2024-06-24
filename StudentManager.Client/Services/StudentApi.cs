namespace StudentManager.Client.Services
{
    public class StudentApi
    {
        private readonly HttpClient httpClient;

        public StudentApi(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task GetStudentById()
        {

        }
    }
}
