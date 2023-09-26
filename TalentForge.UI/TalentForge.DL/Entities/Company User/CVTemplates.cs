using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentForge.DL.Entities.Company_User
{
    public class CVTemplates
    {

        [Key]
        public int CVTID { get; set; }

        //[ForeignKey("CUID")]
       // public ICollection<CompUser> CUID { get; set; }

        [Required]
        public string FileLocation { get; set; }


    }
}
