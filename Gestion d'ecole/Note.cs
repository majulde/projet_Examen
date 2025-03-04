using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class Note
    {
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public int IdMatiere { get; set; }
        public float ValeurNote { get; set; }
        public Etudiant Etudiant { get; set; }
        public Matiere Matiere { get; set; }
    }
}
