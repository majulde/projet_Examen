using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class DB : DbContext
    {
        public DB() : base("ecoleConnect") { }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<OTPCode> OTPCodes { get; set; }
        public DbSet<ClasseCours> ClassesCours { get; set; }
        public DbSet<CoursMatiere> CoursMatieres { get; set; }
        public DbSet<ProfesseurMatiere> ProfesseursMatieres { get; set; }
        public DbSet<ProfesseurClasse> ProfesseursClasses { get; set; }
    }
}
