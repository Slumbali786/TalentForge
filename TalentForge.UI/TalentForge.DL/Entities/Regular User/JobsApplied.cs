using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentForge.DL.Entities.Company_User;

namespace TalentForge.DL.Entities.Regular_User
{
    public class JobsApplied
    {

        [Key]
        public int JAID { get; set; }

       // [ForeignKey("RUID")]
        //public ICollection<RegUser> RUID { get; set; }

        //[ForeignKey("JID")]
        //public ICollection<Jobs> JID { get; set; }

        [Required]
        public string Status { get; set; }

    }
}
