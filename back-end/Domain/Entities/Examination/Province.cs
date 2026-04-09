using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Examination
{
    public class Province
    {
        [Key]
        public decimal PK { get; set; }
        public int ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }
        public string? Abrev { get; set; }


    }
}
