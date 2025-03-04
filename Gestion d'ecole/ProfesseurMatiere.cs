using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class ProfesseurMatiere
    {
        [Key, Column(Order = 0)]
        public int IdProfesseur { get; set; }
        [Key, Column(Order = 1)]
        public int IdMatiere { get; set; }
        public Professeur Professeur { get; set; }
        public Matiere Matiere { get; set; }
    }
}
