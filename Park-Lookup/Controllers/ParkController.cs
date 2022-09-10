using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Park_Lookup.Models;
using Pagination.WebApi.Helpers;

namespace Park_Lookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParkController : ControllerBase
  {
    private readonly Park_LookupContext _db;
     private readonly IUriService uriService;
     public ParkController(Park_LookupContext db, IUriService uriService)
     {
        _db = db;
       this.uriService = uriService;
     }

     [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    {
          var route = Request.Path.Value;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await _db.Parks
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToListAsync();
      var pagedResponse = PaginationHelper.CreatePagedResponse<Customer>(pagedData, validFilter, totalRecords, uriService, route);
      return Ok(pagedResponse);
    }

    [HttpGet("by")]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string type)
    {
      var query = _db.Parks.AsQueryable();

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      return await query.ToListAsync();
    }

   

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = park.ParkId }, park);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);

    if (park == null)
    {
        return NotFound();
    }

      // var park = await _db.Parks.Where(a => a.Id == id).FirstOrDefaultAsync();
    return Ok(new Response<Park>(park));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}