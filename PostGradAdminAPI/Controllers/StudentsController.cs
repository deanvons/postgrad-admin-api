using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PostGradAdminAPI.Models;
using PostGradAdminAPI.Models.DTOs;
using PostGradAdminAPI.Services;

namespace PostGradAdminAPI.Controllers
{
    [Route("api/v1/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;
        private readonly IMapper _mapper;
        public StudentsController(StudentService studentService,IMapper mapper) { 
        _studentService = studentService;
            _mapper = mapper;
        
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentById(int id)
        {

           var student = _studentService.GetById(id);

           var studentReadDTO = _mapper.Map<StudentReadDTO>(student);

           return Ok(studentReadDTO);

        }


        [HttpGet]
        public ActionResult<IEnumerable<StudentReadDTO>> GetStudents()
        {
            
            var students = _studentService.GetAllStudents();

            // convert Student to StudentReadDTO

            return Ok(students);


        }


        [HttpPost]
        public ActionResult CreateStudent([FromBody]Student student)
        {

           var newStudent =  _studentService.CreateStudent(student);

            return Ok();

        }


        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {

            _studentService.Delete(id);

            return NoContent();

        }

        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, [FromBody]Student student)
        {
            // student has a edit form

            _studentService.ReplaceStudent(id, student);

            return NoContent();


        }


    }
}
