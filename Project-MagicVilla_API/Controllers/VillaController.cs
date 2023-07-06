using Microsoft.AspNetCore.Mvc;
using Project_MagicVilla_API.Repository;
using Project_MagicVilla_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.JsonPatch;

namespace Project_MagicVilla_API.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        private readonly IVillaRepository _villaRepository;

        public VillaController(IVillaRepository villaRepository)
        {
            this._villaRepository = villaRepository;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult GetVillas()
        {
            IEnumerable<Villa> villaList = _villaRepository.GetVillas();
            if(villaList == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(villaList);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status404NotFound)]
        public ActionResult GetVilla(int id)
        {
            if(id == 0 )
            {
                return BadRequest();
            }

            Villa villa = _villaRepository.GetVilla(id);
            if(villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult CreateVilla([FromBody]Villa villa)
        {
            if(_villaRepository.GetVillas().FirstOrDefault(x=>x.Name.ToLower() == villa.Name.ToLower()) != null)
            {
                ModelState.AddModelError("Exist", "Villa Name alredy exists");
                return BadRequest(ModelState);
            }
            if(villa == null)
            {
                return BadRequest();
            }
            if (villa.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            if (ModelState.IsValid)
            {
                _villaRepository.CreateVilla(villa);
            }
            return NoContent();         
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                ModelState.AddModelError("Custom", "ID must be greater than 0");
                return BadRequest(ModelState);
            }
            Villa? deleteVilla = _villaRepository.GetVillas().FirstOrDefault(x => x.Id == id);
            if (deleteVilla == null)
            {
                return NotFound();
            }
            _villaRepository.DeleteVilla(deleteVilla.Id, deleteVilla);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateVilla(int id,[FromBody]Villa villa)
        {
            if(id!=villa.Id)
            {
                ModelState.AddModelError("IdError", "Id Not Matching");
                return BadRequest(ModelState);
            }
            if (id == 0)
            {
                ModelState.AddModelError("Message", "Id cannot be Zero");
                return BadRequest(ModelState);
            }

             _villaRepository.UpdateVilla(villa);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        public IActionResult UpdatePatch(int id,JsonPatchDocument<Villa> patchVilla)
        {
            if(id==0 && patchVilla == null)
            {
                return BadRequest();
            }
            Villa? villa = _villaRepository.GetVillas().FirstOrDefault(x=>x.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            //patchVilla.ApplyTo(villa);
            Villa toUpdate = _villaRepository.PatchUpdateVilla(patchVilla,villa);
            _villaRepository.UpdateVilla(toUpdate);
            return NoContent();
        }
    }
}
