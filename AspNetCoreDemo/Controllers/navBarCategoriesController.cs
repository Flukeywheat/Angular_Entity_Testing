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
using SQLitePCL;

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
            List<navBarCategory> categoryList = await _context.Categories.ToListAsync();


            foreach (var category in categoryList)
            {
                category.DropDownItem = await _context.navBarDropDownItem.Where(x => x.NavBarCategoryId == category.NavBarCategoryId).ToListAsync();
            }
            return categoryList;

        }    
      
    }
}
