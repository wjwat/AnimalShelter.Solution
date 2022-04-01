using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AnimalShelter.Api.Models;

namespace AnimalShelter.Api.Controllers
{
  /// <summary>
  /// Full CRUD access to all the animals at our animal shelter.
  /// </summary>
  [ApiController]
  [ApiVersion("1.0")]
  [Route("api/[controller]")]
  [Route("api/{apiVersion}/[controller]")]
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
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    // POST /api/Animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = animal.AnimalId }, animal);
    }

    // PUT /api/Animals/<id>
    // DELETE /api/Animals/<id>

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(a => a.AnimalId == id);
    }
  }
}