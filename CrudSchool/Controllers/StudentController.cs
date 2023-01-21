using Core.Entities;
using Core.Interfaces;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace CrudSchool.Controllers
{
    public class StudentController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            try
            {
                var student = await _unitOfWork.StudentRepository.GetAllAsync();
                return Ok(student);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
