using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Models.NavBarControls
{
    public class NavBarCategoryContext : DbContext
    {
        public NavBarCategoryContext(DbContextOptions<NavBarCategoryContext> options) : base(options)
        {

        }

        public DbSet<navBarCategory> Categories { get; set; }
        public DbSet<navBarDropDownItem> navBarDropDownItem { get; set; }
      
    }


    
    
   
}
