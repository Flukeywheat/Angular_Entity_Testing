using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Models.NavBarControls
{
    public class NavBarCategory
    {
        [Key] private int NavBarCategoryId { get;  }

        [Required] [Column(TypeName = "varchar (100)")]
        private string Name { get;  }

        private List<NavBarDropDownItem> DropDownItem { get; }

    }

    public class NavBarDropDownItem
    {
        [Key] private int NavBarDropDownItemiD { get; }

        [Required]
        [Column(TypeName = "varchar (100)")]
        private string Name { get;  }
        [Required]
        [Column(TypeName = "varchar (100)")]
        private string relativePath { get; }
        [ForeignKey("NavBarCategory")]
        private int NavBarCategoryId { get;}

    }
}
