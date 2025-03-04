using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class Professeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public List<ProfesseurMatiere> ProfesseursMatieres { get; set; }
        public List<ProfesseurClasse> ProfesseursClasses { get; set; }
    }
}
