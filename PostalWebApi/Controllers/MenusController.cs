﻿using System;
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
    public class MenusController : ControllerBase
    {
        private readonly PostalWebApiContext _context;

        public MenusController(PostalWebApiContext context)
        {
            _context = context;
        }

        // GET: api/Menus
        [HttpGet]
        public IEnumerable<Menu> GetMenu()
        {
            return _context.Menu;
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenu([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var menu = await _context.Menu.FindAsync(id);

            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }

        // PUT: api/Menus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu([FromRoute] int id, [FromBody] Menu menu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != menu.Id)
            {
                return BadRequest();
            }

            _context.Entry(menu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuExists(id))
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

        // POST: api/Menus
        [HttpPost]
        public async Task<IActionResult> PostMenu([FromBody] Menu menu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Menu.Add(menu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenu", new { id = menu.Id }, menu);
        }

        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var menu = await _context.Menu.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }

            _context.Menu.Remove(menu);
            await _context.SaveChangesAsync();

            return Ok(menu);
        }

        private bool MenuExists(int id)
        {
            return _context.Menu.Any(e => e.Id == id);
        }
    }
}