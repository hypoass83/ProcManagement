using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class Division
    {
        [Key]
        public decimal PK { get; set; }
        public int DivisionCode { get; set; }
        public string? DivisionName { get; set; }
        public string? DivTag { get; set; }
        public int? ProvinceCode { get; set; }


    }
}
