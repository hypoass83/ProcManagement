using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class Candidate
    {
        [Key]
        public decimal PK { get; set; }
        public int? ExamCode { get; set; }
        public int? Session { get; set; }
        public int ExamCentreCode { get; set; }
        public string CandNumber { get; set; }
        public string? CandName { get; set; }
        public string? BirthDate { get;set; }
        public string? Sex { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? TelNo { get; set; }
        public string? Email { get; set; }
        public string? Specialty { get; set; }
        public string? SpecialtyNA { get; set; }

    }
}
