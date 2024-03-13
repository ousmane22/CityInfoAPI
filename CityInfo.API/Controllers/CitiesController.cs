using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {

       [HttpGet]
        public JsonResult GetAllCities()
        {
            return new JsonResult(
                new List<object>
                {
                      new {id = 1, name = "Ousmane"},
                      new {id = 2, name = "Fatou"},
                }); 
        }
    }
}
