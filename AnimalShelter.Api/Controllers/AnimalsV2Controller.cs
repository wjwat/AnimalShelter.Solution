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
  [ApiVersion("2.0")]
  [Route("api/v{version:apiVersion}/[controller]")]
  [Route("api/[controller]")]
  public class Animals2Controller : Controller
  {
    private readonly AnimalShelterApiContext _db;

    public Animals2Controller(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // GET /api/Animals
    /// <summary>
    /// Returns a list of all animals available at our shelter with filters
    /// applied if they are passed in.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(
        string name,
        string species,
        string breed,
        string description,
        Status? status
      )
    {
      var query = _db.Animals.AsQueryable();

      if (name != null)
        query = query.Where(a => a.Name == name);
      if (species != null)
        query = query.Where(a => a.Species == species);
      if (breed != null)
        query = query.Where(a => a.Breed == breed);
      if (description != null)
        query = query.Where(a => a.Description.Contains(description));
      if (status != null)
        query = query.Where(a => a.Status == status);

      return await query.ToListAsync();
    }

    /// <summary>
    /// Returns a single random animal from our list of available animals
    /// </summary>
    [HttpGet("random")]
    public async Task<ActionResult<Animal>> Random()
    {
      var count = await _db.Animals.CountAsync();
      var random = new Random()
        .Next(count);

      return await _db.Animals.Skip(random).FirstOrDefaultAsync();
    }
  }
}