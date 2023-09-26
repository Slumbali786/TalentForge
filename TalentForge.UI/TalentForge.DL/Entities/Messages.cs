using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentForge.DL.Entities
{
    public class Messages
    {

        [Key]
        public int MID { get; set; }

       // [ForeignKey("RUID")]
        //public ICollection<RegUser> RUID { get; set; }

        //[ForeignKey("CUID")]
        //public ICollection<CompUser> CUID { get; set; }

        public string RUMessage { get; set; }

        public string CUMessage { get; set; }

    }
}
