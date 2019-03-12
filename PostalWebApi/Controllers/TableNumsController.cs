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
    public class TableNumsController : ControllerBase
    {
        private readonly StaffContext _context;

        public TableNumsController(StaffContext context)
        {
            _context = context;
        }

        // GET: api/TableNums
        [HttpGet]
        public IEnumerable<TableNum> GetTableNum()
        {
            return _context.TableNum;
        }

        // GET: api/TableNums/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTableNum([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tableNum = await _context.TableNum.FindAsync(id);

            if (tableNum == null)
            {
                return NotFound();
            }

            return Ok(tableNum);
        }

        // PUT: api/TableNums/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTableNum([FromRoute] int id, [FromBody] TableNum tableNum)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tableNum.Id)
            {
                return BadRequest();
            }

            _context.Entry(tableNum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableNumExists(id))
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

        // POST: api/TableNums
        [HttpPost]
        public async Task<IActionResult> PostTableNum([FromBody] TableNum tableNum)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TableNum.Add(tableNum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTableNum", new { id = tableNum.Id }, tableNum);
        }

        // DELETE: api/TableNums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTableNum([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tableNum = await _context.TableNum.FindAsync(id);
            if (tableNum == null)
            {
                return NotFound();
            }

            _context.TableNum.Remove(tableNum);
            await _context.SaveChangesAsync();

            return Ok(tableNum);
        }

        private bool TableNumExists(int id)
        {
            return _context.TableNum.Any(e => e.Id == id);
        }
    }
}