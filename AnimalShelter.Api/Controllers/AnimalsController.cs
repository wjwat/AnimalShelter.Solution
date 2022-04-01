using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AnimalShelter.Api.Models;

namespace AnimalShelter.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // GET /api/Animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()
    {
      var query = _db.Animals.AsQueryable();

      return await query.ToListAsync();
    }
    // GET /api/Animals/<id>
    // POST /api/Animals
    // PUT /api/Animals/<id>
    // DELETE /api/Animals/<id>

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(a => a.AnimalId == id);
    }
  }
}