using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class Examcentre
    {
        [Key]
        public decimal ID { get; set; }
        public int ExamCentreCode { get; set; }
        public string? ExamCentreName { get; set; }
        public string? CentreType { get; set; }
        public string? ExamType { get; set; }
        public int? AcomCentreCode { get; set; }
        public int? DivCode { get;set; }
        public int? SubDivCode { get; set; }

    }
}
