using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentForge.DL.Entities.Regular_User
{
    public class EmployeeHistory
    {

        [Key]
        public int EHID { get; set; }

      //  [ForeignKey("RUID")]
        //public ICollection<RegUser> RUID { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Reference { get; set; }

        [Required]
        public string ReferenceContact { get; set; }

    }
}
