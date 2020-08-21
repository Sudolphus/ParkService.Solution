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

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      IEnumerable<Park> parkList = _db.Parks
        .ToList()
        .OrderBy(p => p.State)
        .ThenBy(p => p.Name);
      return parkList;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> Get(int id)
    {
      Park park = await _db.Parks.FirstOrDefaultAsync(p => p.ParkId == id);
      return park;
    }


  }
}
