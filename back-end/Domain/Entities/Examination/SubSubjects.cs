using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class SubSubjects
    {
        [Key]
        public decimal PK { get; set; }
        public string SubjectCode { get; set; }
        public int PaperNumber { get; set; }
        public int? NbrPerEnv { get; set; }
        


    }
}
