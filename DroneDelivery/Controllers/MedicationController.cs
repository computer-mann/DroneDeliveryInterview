using DroneDelivery.Filters;
using DroneDelivery.Models;
using DroneDelivery.Models.Db;
using DroneDelivery.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DroneDelivery.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CustomModelStateValidationAttribute))]
    public class MedicationController : ControllerBase
    {
        private readonly DroneDeliveryDbContext _dbContext;
        public MedicationController(DroneDeliveryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("/medication")]
        public async Task<IActionResult> CreateMedication([FromBody] CreateMedicationViewModel vm) 
        {
            if (vm == null) return BadRequest(new ErrorViewModel("Empty request body."));

            var medication=new Medication() { Name = vm.Name , Image=vm.Image,Code=vm.Code,Weight=300};
            var res=_dbContext.Medications.Add(medication);
            await _dbContext.SaveChangesAsync();
            return Created($"/medication/{res.Entity.Id}",medication);
        }

        [HttpPut("/medication/{id}")]
        public async Task<IActionResult> EditMedication(int? id, [FromBody] EditMedicationViewModel vm)
        {
            if (id == null) return BadRequest(new ErrorViewModel("Resource not found."));

            var res=await _dbContext.Medications.FindAsync(id);
            if (res == null) return BadRequest(new ErrorViewModel("Resource not found."));
            
            res.Name = vm.Name;
            res.Image = vm.Image;
            res.Weight = vm.Weight;
            res.Code = vm.Code;
            _dbContext.Medications.Update(res);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("/medication/{id}")]
        public async Task<IActionResult> DeleteMedication(int? id)
        {
            if (id == null) return BadRequest(new ErrorViewModel("Resource not found."));
            var res= await _dbContext.Medications.FindAsync(id);
            if (res == null) return BadRequest(new ErrorViewModel("Resource not found."));
            _dbContext.Medications.Remove(res);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpGet("/medication/{id}")]
        public async Task<IActionResult> GetMedication(int? id)
        {
            if (id == null) return BadRequest(new ErrorViewModel("Resource not found."));
            return await _dbContext.Medications.FindAsync(id) switch
            {
                Medication medication => Ok(medication),
                _ => NotFound(new ErrorViewModel("No such Resource."))
            };
        }
    }
}
