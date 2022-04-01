using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
  [ApiVersion("1.1")]
  [Route("api/[controller]")]
  [Route("api/{version:apiVersion}/[controller]")]
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
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      // Why catch the exception instead of checking to see if the Animal exists
      // first?
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      // What would be a good status to return for a successful update? NoContent
      // feels wrong.
      return NoContent();
    }

    // DELETE /api/Animals/<id>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      // Same question as in our PUT route.
      return NoContent();
    }

    // TODO: figure out how to separate this out to another swagger doc, or
    // indicate that it should only be available on another version in the url
    [MapToApiVersion("1.1")]
    [HttpGet("random")]
    public async Task<ActionResult<Animal>> Random()
    {
      var count = await _db.Animals.CountAsync();
      var random = new Random()
        .Next(count);

      return await _db.Animals.Skip(random).FirstOrDefaultAsync();
    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(a => a.AnimalId == id);
    }
  }
}