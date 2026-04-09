using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class SpecSubject
    {
        [Key]
        public decimal PK { get; set; }
        public int ExamCode { get; set; }
        public string SpecialtyCode { get; set; }
        public string SubjectCode { get; set; }

    }
}
