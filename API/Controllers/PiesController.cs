using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
  [ApiController]
  [Route("api/v1/pies")]
    public class PiesController : ControllerBase
    {

      public PiesController(){
        
      }

      [HttpGet]
      public IActionResult GetPies()
      {
        return Ok(PiesDataStore.Current.Pies);
      }

      [HttpGet("{id}")]
      public IActionResult GetPie(int id)
      {
        var pieToReturn = PiesDataStore.Current.Pies.FirstOrDefault(p => p.Id == id);
        if (pieToReturn == null)
        {
          return NotFound();
        }

        return Ok(pieToReturn);
      }
    }
}