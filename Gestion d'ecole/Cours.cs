using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class Cours
    {
        public int Id { get; set; }
        public string NomCours { get; set; }
        public string Description { get; set; }
        public ICollection<CoursMatiere> CoursMatieres { get; set; }
        public ICollection<ClasseCours> ClassesCours { get; set; }
    }
}
