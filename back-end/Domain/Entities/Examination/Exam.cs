using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class Exam
    {
        [Key]
        public decimal PK { get; set; }
        public int ExamCode { get; set; }
        public string? ExamName { get; set; }
        public string? ExamType { get; set; }
        public int? RegFee { get; set; }
        public float? SubjectFee { get; set; }
        public float? PracticalFee { get;set; }


    }
}
