using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class Subjects
    {
        [Key]
        public decimal PK { get; set; }
        public string SubjectCode { get; set; }
        public string? SubjectName { get; set; }
        public string? Abbreviation { get; set; }
        public string? SubjectTag { get; set; }
        public int? NumPapers { get; set; }
    }
}
