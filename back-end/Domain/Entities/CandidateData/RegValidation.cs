using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class RegValidation
    {
        [Key]
        public decimal PK { get; set; }
        public int? ExSession { get; set; }
        public string CandNumber { get; set; }
        public string PmtCode { get; set; }
        public float? AmtPaid { get; set; }

    }
}
