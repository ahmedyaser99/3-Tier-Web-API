using BLL.DTO;
using BLL.Services;
using DAL.Context;
using DAL.Models;
using DAL.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        IInstructorManager InstructorManager;
        Task02Context context;
        IInstructorRepository Repository;
        public InstructorController(IInstructorManager _instructorManger, Task02Context _context, IInstructorRepository _repository)
        {
            InstructorManager = _instructorManger;
            context = _context;
            Repository = _repository;
        }
        // GET: api/<InstructorController>
        [HttpGet]
        public ActionResult GetAll()
        {
            List<InstructorDTO> ins = InstructorManager.GetAll().ToList();
            if (ins.Count > 0)
            {
                return Ok(ins);
            }
            return BadRequest();
        }

        // GET api/<InstructorController>/5
        [HttpGet("{Id:int}")]
        public ActionResult GetById(int Id)
        {
            return Ok(InstructorManager.GetById(Id));
        }
        [HttpGet]
        [Route("{name:alpha}")]
        public IActionResult InstructorByName(string name)
        {
            var course = context.Instructors.Where(c => c.Name == name).FirstOrDefault();
            if (course == null)
                return NotFound();
            return Ok(course);
        }
        ////add
        [HttpPost]
        public ActionResult post(Instructor instructor)
        {
            Repository.Insert(instructor);
            return Created("Created", instructor/* Repository.GetAll().ToList()*/);
        }

        //edit
        [HttpPut]
        public IActionResult Put(int id, [FromBody] Instructor instructor)
        {
            Repository.UpdateInstructor(id, instructor);
            return Ok();
        }
        //delete
        [HttpDelete("{id}")]
        public IActionResult deleteInstructor(int id)
        {
            Repository.DeleteInstructor(id);
            return Ok(InstructorManager.GetAll().ToList());
        }
    }
}
