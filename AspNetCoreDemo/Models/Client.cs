using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Models
{
    public class Client
    {
        [Key] public int userId { get; set; }

        [Required][Column(TypeName = "varchar (100)")] 
        public string UserName { get; set; }

        [Required] [Column(TypeName = "varchar (100)")]
        public string Email { get; set; }

        [Required] [Column(TypeName = "varchar (100)")]
        public string Password { get; set; }
    }
}
