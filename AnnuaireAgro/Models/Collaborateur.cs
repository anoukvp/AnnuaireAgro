using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAgro.Models
{

    public class Collaborateur
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nom { get; set; }

        [Required]
        [StringLength(80)]
        public string Prenom { get; set; }

            
        [StringLength(80)]
        public string TelFixe { get; set; }

        [StringLength(20)]
        public string TelPortable { get; set; }
    
        [StringLength(160)]
        public string Email { get; set; }


        public int FK_idSite { get; set; }

        public Site site { get; set; }

        public int FK_idService { get; set; }

        public Service service { get; set;  }





    }
}
