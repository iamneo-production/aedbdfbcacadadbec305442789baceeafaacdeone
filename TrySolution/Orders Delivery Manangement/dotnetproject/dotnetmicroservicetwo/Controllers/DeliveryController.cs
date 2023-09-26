using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetmicroservicetwo.Models;

namespace dotnetmicroservicetwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly DeliveryDbContext _context;

        public DeliveryController(DeliveryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Delivery>>> GetAllDeliverys()
        {
            var deliverys = await _context.Deliverys.ToListAsync();
            return Ok(deliverys);
        }

        [HttpPost]
        public async Task<ActionResult> AddDelivery(Delivery delivery)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return detailed validation errors
            }
            await _context.Deliverys.AddAsync(delivery);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDelivery(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid Delivery id");

            var delivery = await _context.Deliverys.FindAsync(id);
              _context.Deliverys.Remove(delivery);
                await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
