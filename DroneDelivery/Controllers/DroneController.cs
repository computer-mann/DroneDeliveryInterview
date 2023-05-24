using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DroneDelivery.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class DroneController : ControllerBase
    {
         
        public DroneController() { }

        
        [HttpPost("/drone")]
        public IActionResult CreateDrone()
        {
            return Ok();
        }
        //public IActionResult EditDrone() 
        //{
        //    return Ok();
        //}
        //public IActionResult DeleteDrone()
        //{
        //    return Ok();
        //}
        //public IActionResult GetDrone() 
        //{
        //    return Ok();
        //}
    }
}
