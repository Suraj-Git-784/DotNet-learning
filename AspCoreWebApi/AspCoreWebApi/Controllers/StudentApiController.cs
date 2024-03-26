using AspCoreWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreWebApi.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly DatabaseFirstContext context;

        public StudentApiController(DatabaseFirstContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentTable>>> GetStudents()
        {
            var StudentData = await context.StudentTables.ToListAsync();
            return Ok(StudentData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentTable>> GetStudentById(int id)
        {
            var student = await context.StudentTables.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<StudentTable>> CreateStudent(StudentTable std)
        {
            await context.StudentTables.AddAsync(std);
            await context.SaveChangesAsync();
            return Ok(std);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<StudentTable>> UpdateStudent(int id, StudentTable std)
        {
            if(id != std.Id)
            {
                return BadRequest();
            }
            context.Entry(std).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(std);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentTable>> DeleteStudent(int id)
        {
            var std = await context.StudentTables.FindAsync(id);
            if(std == null)
            {
                return NotFound();
            }
            context.StudentTables.Remove(std);
            await context.SaveChangesAsync();
            return Ok(std);
        }
    }
}
