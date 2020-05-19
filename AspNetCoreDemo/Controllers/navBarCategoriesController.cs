using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspNetCoreDemo.Models.NavBarControls;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Runtime.InteropServices;

namespace AspNetCoreDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class navBarCategoriesController : ControllerBase
    {
        private readonly NavBarCategoryContext _context;

        public navBarCategoriesController(NavBarCategoryContext context)
        {
            _context = context;
        }

        // GET: navBarCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<navBarCategory>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();          
        }

        // GET: api/navBarCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<navBarCategory>> GetnavBarCategory(int id)
        {
            var navBarCategory = await _context.Categories.FindAsync(id);

            if (navBarCategory == null)
            {
                return NotFound();
            }

            return navBarCategory;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutnavBarCategory(int id, navBarCategory navBarCategory)
        {
            if (id != navBarCategory.NavBarCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(navBarCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!navBarCategoryExists(id))
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

      
        [HttpPost]
        public async Task<ActionResult<navBarCategory>> PostnavBarCategory(navBarCategory navBarCategory)
        {
            _context.Categories.Add(navBarCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetnavBarCategory", new { id = navBarCategory.NavBarCategoryId }, navBarCategory);
        }

        // DELETE: api/navBarCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<navBarCategory>> DeletenavBarCategory(int id)
        {
            var navBarCategory = await _context.Categories.FindAsync(id);
            if (navBarCategory == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(navBarCategory);
            await _context.SaveChangesAsync();

            return navBarCategory;
        }

        private bool navBarCategoryExists(int id)
        {
            return _context.Categories.Any(e => e.NavBarCategoryId == id);
        }
    }
}
