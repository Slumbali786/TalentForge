using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentForge.DL.Entities.Regular_User;

namespace TalentForge.DL.Entities.Company_User
{
    public class Jobs
    {

        [Key]
        public int JID { get; set; }

       // [ForeignKey("CUID")]
        //public ICollection<CompUser> CUID { get; set; }

        [Required]
        public string JobType { get; set; }

        [Required]
        public string JobDescription { get; set; }

        public ICollection<JobsApplied> JobsApplied { get; set; }
    }
}
