using DroneDelivery.Filters;
using DroneDelivery.Models;
using DroneDelivery.Models.Db;
using DroneDelivery.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DroneDelivery.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CustomModelStateValidationAttribute))]
    public class DroneController : ControllerBase
    {
         private readonly DroneDeliveryDbContext _dbContext;
        public DroneController(DroneDeliveryDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpPost("/drone")]
        public IActionResult CreateDrone([FromBody] CreateDroneViewModel vm)
        {
            var drone=new Drone() { SerialNumber=vm.SerialNumber,WeightLimit=vm.WeightLimit,
                State=State.IDLE,BatteryCapacity=vm.BatteryCapacity,Model=}
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
