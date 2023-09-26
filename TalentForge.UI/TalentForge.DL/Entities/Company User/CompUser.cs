using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentForge.DL.Entities.Company_User;
using TalentForge.DL.Entities.Regular_User;

namespace TalentForge.DL.Entities
{
    public class CompUser
    {

        [Key]
        public int CUID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string IDNum { get; set; }

        [Required]
        public string Company { get; set; }

       // [ForeignKey("CUID")]
        public ICollection<CVTemplates> CVTemplates { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<Messages> Messages { get; set; }

    }
}
