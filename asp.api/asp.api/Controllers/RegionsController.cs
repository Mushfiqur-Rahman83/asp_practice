using asp.api.models.domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland Region",
                    Code = "AKL",
                    RegImgUrl = "https://www.istockphoto.com/photo/2018-jan-3-auckland-new-zealand-panorama-view-beautiful-landcape-of-the-building-in-gm1060826424-283569015?searchscope=image%2Cfilm"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegImgUrl = "https://media.istockphoto.com/id/866887704/photo/wellington-cable-car-the-landmark-of-new-zealand.jpg?s=1024x1024&w=is&k=20&c=a78EVHx-SsTNIso_x6pcpesS4bZOxuBM4FDFpQZoZNI="
                }
            };
            return Ok(regions);
        }
    }
}
