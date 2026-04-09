using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class AcomCentre
    {
        [Key]
        public decimal PK { get; set; }
        public int AcomCentreCode { get; set; }
        public string? AcomCentreName { get; set; }
        public int? DivCode { get; set; }
        public string? DivTag { get; set; }
        public int? TrDivCode { get; set; }


    }
}
