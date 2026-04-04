using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Security
{
    public class Employe
    {
        public int PK { get; set; }
        public string Matricule { get; set; }
        public string NomPrenom { get; set; }
        public string Qualite { get; set; }
        public string MotPasse { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        
    }
}
