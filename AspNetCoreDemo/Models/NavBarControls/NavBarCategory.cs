using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Models.NavBarControls
{
    public class navBarCategory
    {
        [Key] public int NavBarCategoryId { get; private set; }

        [Required] [Column(TypeName = "varchar (100)")]
        public string Name { get; private set; }

        public List<navBarDropDownItem> DropDownItem { get;  set; }
    }

    public class navBarDropDownItem
    {
        [Key] public int NavBarDropDownItemiD { get; private set; }

        [Required]
        [Column(TypeName = "varchar (100)")]
        public string Name { get; private set; }
        [Required]
        [Column(TypeName = "varchar (100)")]
        public string relativePath { get; private set; }
        [ForeignKey("NavBarCategory")]
        public int NavBarCategoryId { get; private set; }

    }
}
