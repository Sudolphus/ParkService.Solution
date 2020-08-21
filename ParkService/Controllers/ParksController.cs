using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkService.Models;

namespace ParkService.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParkContext _db;
    public ParksController(ParkContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      List<Park> parkList = await _db.Parks.ToListAsync();
      return parkList;
    }

    // GET api/parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> Get(int id)
    {
      Park park = await _db.Parks.FirstOrDefaultAsync(p => p.ParkId == id);
      return park;
    }

    //POST api/parks
    [HttpPost]
    public async Task Post([FromBody] Park park)
    {
      await _db.Parks.AddAsync(park);
      await _db.SaveChangesAsync();
    }

    //PUT api/parks/5
    [HttpPut("{id}")]
    public async Task Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      await _db.SaveChangesAsync();
    }

    //DELETE api/parks/5
    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
      Park park = await _db.Parks.FirstOrDefaultAsync(p => p.ParkId == id);
      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();
    }
  }
}