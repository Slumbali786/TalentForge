using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentForge.DL.Entities.Regular_User
{
    public class SchoolInfo
    {

        [Key]
        public int SIID { get; set; }

       // [ForeignKey("RUID")]
        //public ICollection<RegUser> RUID { get; set; }

        [Required]
        public string LSchoolAttended { get; set; }

        [Required]
        public int HGradePassed { get; set; }

        [Required]
        public int FinalYear { get; set; }

        [Required]
        public bool SubMath { get; set; }

        [Required]
        public bool SubMathL { get; set; }

        [Required]
        public bool SubPhysics { get; set; }

        [Required]
        public bool SubLS { get; set; }

        [Required]
        public bool SubLO { get; set; }

        [Required]
        public bool SubEng { get; set; }

        [Required]
        public bool SubAfrik { get; set; }

        [Required]
        public bool SubZulu { get; set; }

        [Required]
        public bool SubIT { get; set; }

        [Required]
        public bool SubAccounting { get; set; }

        [Required]
        public bool SubBusiness { get; set; }

        [Required]
        public bool SubTourism { get; set; }

        [Required]
        public bool SubArt { get; set; }

        [Required]
        public bool SubDrama { get; set; }
    }
}
