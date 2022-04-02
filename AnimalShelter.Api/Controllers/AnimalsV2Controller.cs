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
  [ApiVersion("2.0")]
  [Route("api/v{version:apiVersion}/[controller]")]
  [Route("api/[controller]")]
  public class Animals2Controller : Controller
  {
    private readonly AnimalShelterApiContext _db;
    private readonly IUriService _uriService;

    public Animals2Controller(AnimalShelterApiContext db, IUriService uriService)
    {
      _db = db;
      _uriService = uriService;
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
        Status? status,
        [FromQuery] PaginationFilter filter
      )
    {
      var route = Request.Path.Value + Request.QueryString;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
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

      var pagedData = await query
          .Skip((validFilter.PageNumber -1) * validFilter.PageSize)
          .Take(validFilter.PageSize)
          .ToListAsync();
      var totalRecords = await query.CountAsync();

      var resp = PaginationHelper.CreatePagedResponse<Animal>(
          pagedData,
          validFilter,
          totalRecords,
          _uriService,
          route
      );

      return Ok(resp);
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