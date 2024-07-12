using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models.Dto;
using SharedLibrary.Models.Entity;
using StudentManager.Server.CustomActionFilters;
using StudentManager.Server.Repository.Contract;


namespace StudentManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize]


        public async Task<IActionResult> GetStudentId([FromRoute] Guid id)
        {
            var student = await studentRepository.GetByIdAsync(id);
            return Ok(mapper.Map<StudentDto>(student));
        }

        // GET: api/student/list?filterOn=Name&filterQuery=Track&isAscending=true
        [HttpGet]
        [Route("list")]
        [Authorize]
        public async Task<IActionResult> GetAllStudents([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 100)
        {
            var students = await studentRepository.GetAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber, pageSize);
            return Ok(mapper.Map<List<StudentDto>>(students));


        }
        // POST: api/student
        [HttpPost]
        [Route("createstudent")]
        [ValidateModel]
        [Authorize]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentDto createStudentDto)
        {
            var student = mapper.Map<Student>(createStudentDto);
            await studentRepository.CreateStudentAsync(student);
            return Ok(mapper.Map<StudentDto>(student));
        }
        // PUT: api/student
        [HttpPut]
        [ValidateModel]
        [Authorize]

        public async Task<IActionResult> UpdateStudent(Student student)
        {
            mapper.Map<Student>(student);
            var result = await studentRepository.UpdateStudentAsync(student);
            return Ok(result);
        }

        // DELETE: api/student
        [HttpDelete]
        [Route("{id}")]
        [Authorize]

        public async Task<IActionResult> DeleteStudent([FromRoute] Guid id)
        {
            await studentRepository.DeleteByIdAsync(id);
            return Ok("Student Deleted Successfuly");
        }

        // DELETE: api/student
        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteAllStudents()
        {
            await studentRepository.DeleteAllStudentsAsync();
            return NoContent();
        }

    }
}

