using System.Linq;
using API.DataStores;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ShopSearchParams
    {
        [BindProperty(Name = "ne_lat", SupportsGet = true)]
        public double NorthEastLat { get; set; }

        [BindProperty(Name = "ne_lng", SupportsGet = true)]
        public double NorthEastLng { get; set; }

        [BindProperty(Name = "sw_lat", SupportsGet = true)]
        public double SouthWestLat { get; set; }

        [BindProperty(Name = "sw_lng", SupportsGet = true)]
        public double SouthWestLng { get; set; }
    }

    [ApiController]
    [Route("api/v1/shops")]
    public class ShopController : ControllerBase
    {
        public ShopController()
        {
        }

        [HttpGet]
        [EnableCors("Policy")]
        public IActionResult GetShops([FromQuery] ShopSearchParams searchParams)
        {
            var shops =
                ShopDataStore
                    .Current
                    .Shops
                    .Where(shop =>
                        shop.Latitude >= searchParams.SouthWestLat &&
                        shop.Latitude <= searchParams.NorthEastLat &&
                        shop.Longitude >= searchParams.SouthWestLng &&
                        shop.Longitude <= searchParams.NorthEastLng)
                    .ToList();

            // return Ok(searchParams);
            return Ok(shops);
        }
    }
}
