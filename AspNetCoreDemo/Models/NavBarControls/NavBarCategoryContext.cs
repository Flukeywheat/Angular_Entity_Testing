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

        public DbSet<NavBarCategory> Clients { get; set; }
    }
    
    public class NavBarDropDownItemContext : DbContext
    {
        public NavBarDropDownItemContext(DbContextOptions<NavBarDropDownItemContext> options) : base(options)
        {

        }

        public DbSet<NavBarDropDownItem> Clients { get; set; }
    }
}
