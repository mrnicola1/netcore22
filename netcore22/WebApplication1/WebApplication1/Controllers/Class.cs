using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class Class : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);                             
        }
        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {

            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            
            if (cityToReturn == null)
            {
                return NotFound();
            }
            
            return Ok(cityToReturn);
           
        }
    }
}
