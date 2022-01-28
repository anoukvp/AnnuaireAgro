using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAgro.Models
{
    public class Site
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Ville { get; set; }

      

    }
}
