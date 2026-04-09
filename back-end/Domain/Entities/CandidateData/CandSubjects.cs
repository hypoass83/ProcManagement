using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class CandSubjects
    {
        [Key]
        public decimal serie { get; set; }
        public string CandNumber { get; set; }
        public int Session { get; set; }
        public string? SubjectCode { get; set; }

    }
}
