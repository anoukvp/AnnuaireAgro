using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAgro.Models
{

    class Collaborateur
    {
        [Key]
        public int IdCollaborateur { get; set; }

        [Required]
        [StringLength(80)]
        public string Nom { get; set; }

        [Required]
        [StringLength(80)]
        public string Prenom { get; set; }

            
        [StringLength(80)]
        public int TelFixe { get; set; }

        [StringLength(20)]
        public int TelPortable { get; set; }

        [StringLength(160)]
        public string Email { get; set; }

        public int SiteId { get; set; }

        public Site Site { get; set; }

        public int ServiceID { get; set; }

        public Service Service { get; set; }
    }
}
