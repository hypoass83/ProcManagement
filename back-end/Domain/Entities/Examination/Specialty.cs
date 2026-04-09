using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class Specialty
    {
        [Key]
        public decimal PK { get; set; }
        public string SpecialtyCode { get; set; }
        public string? SpecialtyName { get; set; }
        public string? SpecialtyType { get; set; }

    }
}
