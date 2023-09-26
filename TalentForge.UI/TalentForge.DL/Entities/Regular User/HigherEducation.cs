using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentForge.DL.Entities.Regular_User
{
    public class HigherEducation
    {

        [Key]
        public int HEID { get; set; }

       // [ForeignKey("RUID")]
        //public ICollection<RegUser> RUID { get; set; }

        [Required]
        public string CollegeNameLoc { get; set; }

        [Required]
        public string FieldOfStudy { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public bool Complete { get; set; }

    }
}
