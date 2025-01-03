﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kirt_web.Models;

namespace Kirt_web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriesController : ControllerBase
    {
        private readonly apiDbContext _context;

        public SubcategoriesController(apiDbContext context)
        {
            _context = context;
        }

        // GET: api/Subcategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subcategory>>> GetSubcategories()
        {
            return await _context.Subcategories.ToListAsync();
        }

        // GET: api/Subcategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Subcategory>> GetSubcategory(int id)
        {
            var subcategory = await _context.Subcategories.FindAsync(id);

            if (subcategory == null)
            {
                return NotFound();
            }

            return subcategory;
        }

        // PUT: api/Subcategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubcategory(int id, Subcategory subcategory)
        {
            if (id != subcategory.SubcategoryId)
            {
                return BadRequest();
            }

            _context.Entry(subcategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubcategoryExists(id))
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

        // POST: api/Subcategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Subcategory>> PostSubcategory(Subcategory subcategory)
        {
            _context.Subcategories.Add(subcategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubcategory", new { id = subcategory.SubcategoryId }, subcategory);
        }

        // DELETE: api/Subcategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubcategory(int id)
        {
            var subcategory = await _context.Subcategories.FindAsync(id);
            if (subcategory == null)
            {
                return NotFound();
            }

            _context.Subcategories.Remove(subcategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubcategoryExists(int id)
        {
            return _context.Subcategories.Any(e => e.SubcategoryId == id);
        }
    }
}
