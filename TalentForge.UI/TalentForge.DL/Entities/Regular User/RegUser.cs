using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentForge.DL.Entities.Regular_User;

namespace TalentForge.DL.Entities
{
    public class RegUser
    {

        [Key]
        public int RUID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string IDNumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public bool MaritalStatus { get; set; }

        [Required]
        public string ContactNum { get; set;}

        [Required]
        public string Email { get; set;}

        [Required]
        public string ResAddress { get; set;}

        [Required]
        public string PostalAddress { get; set;}

        public ICollection<CVs> CVs { get; set; }
        public ICollection<EmployeeHistory> EmployeeHistories { get; set; }
        public ICollection<HigherEducation> HigherEducations { get; set; }
        public ICollection<JobsApplied> JobsApplied { get; set; }
        public ICollection<SchoolInfo> SchoolInfos { get; set; }
        public ICollection<Skills> Skills { get; set; }
        public ICollection<Messages> Messages { get; set; }

    }
}
