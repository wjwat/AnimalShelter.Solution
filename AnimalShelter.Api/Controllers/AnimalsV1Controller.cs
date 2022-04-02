using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AnimalShelter.Api.Filters;
using AnimalShelter.Api.Helpers;
using AnimalShelter.Api.Models;
using AnimalShelter.Api.Services;
using AnimalShelter.Api.Wrappers;

namespace AnimalShelter.Api.Controllers
{
  /// <summary>
  /// Full CRUD access to all the animals at our animal shelter.
  /// </summary>
  [ApiController]
  [ApiVersion("1.0")]
  [ApiVersion("2.0")]
  [Route("api/v{version:apiVersion}/[controller]")]
  [Route("api/[controller]")]
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterApiContext _db;
    private readonly IUriService _uriService;

    public AnimalsController(AnimalShelterApiContext db, IUriService uriService)
    {
      _db = db;
      _uriService = uriService;
    }

    // GET /api/Animals
    /// <summary>
    /// Return a list of all animals currently at our shelter
    /// </summary>
    [HttpGet, MapToApiVersion("1.0")]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(
      [FromQuery] PaginationFilter filter
    )
    {
      var route = Request.Path.Value;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var query = _db.Animals.AsQueryable();

      var pagedData = await query
          .Skip((validFilter.PageNumber -1) * validFilter.PageSize)
          .Take(validFilter.PageSize)
          .ToListAsync();
      var totalRecords = await _db.Animals.CountAsync();

      var resp = PaginationHelper.CreatePagedResponse<Animal>(
          pagedData,
          validFilter,
          totalRecords,
          _uriService,
          route
      );

      return Ok(resp);
    }

    // GET /api/Animals/<id>
    /// <summary>
    /// Returns an animal with ID equal to {id}
    /// </summary>
    /// <response code="404">Unable to locate an animal with that ID</response>
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
    /// <summary>
    /// Creates an animal
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = animal.AnimalId }, animal);
    }

    // PUT /api/Animals/<id>
    /// <summary>
    /// Updates the fields of an animal with ID of {id}
    /// </summary>
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
    /// <summary>
    /// Removes the animal with an ID of {id}
    /// </summary>
    /// <param name="id" example="1">The Animal ID</param>
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

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(a => a.AnimalId == id);
    }
  }
}