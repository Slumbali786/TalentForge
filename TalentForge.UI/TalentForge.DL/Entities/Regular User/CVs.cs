using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentForge.DL.Entities.Regular_User
{
    public class CVs
    {

        [Key]
        public int CVID { get; set; }

       // [ForeignKey("RUID")]
        //public ICollection<RegUser> RUID { get; set; }

        [Required]
        public string FileLoc { get; set; }

    }
}
