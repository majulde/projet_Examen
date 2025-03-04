using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class Classe
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }
        public ICollection<Etudiant> Etudiants { get; set; }
        public ICollection<ClasseCours> ClassesCours { get; set; }
        public ICollection<ProfesseurClasse> ProfesseursClasses { get; set; }
    }
}
