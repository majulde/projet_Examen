using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class ClasseCours
    {
        [Key, Column(Order = 0)]
        public int IdClasse { get; set; }
        [Key, Column(Order = 1)]
        public int IdCours { get; set; }
        public Classe Classe { get; set; }
        public Cours Cours { get; set; }
    }
}
