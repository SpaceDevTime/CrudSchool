using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CrudSchool.Controllers
{
    public class TeacherController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeacherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Teacher>>> Get()
        {
            try
            {
                var teachers = await _unitOfWork.TeacherRepository.GetAllAsync();
                return Ok(teachers);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


    }
}
