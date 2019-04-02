using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostalWebApi.Models;

namespace PostalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly PostalWebApiContext _context;

        public OrderItemsController(PostalWebApiContext context)
        {
            _context = context;
        }

        // GET: api/OrderItems
        [HttpGet]
        public IEnumerable<OrderItem> GetOrderItem()
        {
            return _context.OrderItem;
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderItem = await _context.OrderItem.FindAsync(id);

            if (orderItem == null)
            {
                return NotFound();
            }

            return Ok(orderItem);
        }

        // PUT: api/OrderItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem([FromRoute] int id, [FromBody] OrderItem orderItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderItems
        [HttpPost]
        public async Task<IActionResult> PostOrderItem([FromBody] OrderItem orderItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.OrderItem.Add(orderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderItem", new { id = orderItem.Id }, orderItem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderItem = await _context.OrderItem.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            _context.OrderItem.Remove(orderItem);
            await _context.SaveChangesAsync();

            return Ok(orderItem);
        }

        private bool OrderItemExists(int id)
        {
            return _context.OrderItem.Any(e => e.Id == id);
        }
    }
}