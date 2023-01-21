using Core.Entities;
using Core.Interfaces;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace CrudSchool.Controllers
{
    public class NoteController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public NoteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Note>>> Get()
        {
            try
            {
                var note = await _unitOfWork.NoteRepository.GetAllAsync();
                return Ok(note);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
