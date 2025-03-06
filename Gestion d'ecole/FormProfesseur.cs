using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_ecole
{
    public partial class FormProfesseur : Form
    {
        public FormProfesseur()
        {
            InitializeComponent();
        }

        private void FormProfesseur_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            dataGridView1.DataSource = null;
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Professeurs.Select(c => new { c.Id, c.Nom, c.Prenom, c.Email, c.Telephone }).ToList();
            }
            
            btnajouterprof.Enabled = true;
            btneffacerprof.Enabled = true;
            btnsupprimerprof.Enabled = false;
            btnmodifprof.Enabled = false;
            effacer();
        }

        private void btneffacerprof_Click(object sender, EventArgs e)
        {
            effacer();
        }
        private void effacer()
        {
            txtemailprof.Text = string.Empty;
            txtnomprof.Text = string.Empty;
            txtprenomprof.Text = string.Empty;
            txttelephoneprof.Text = string.Empty;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                combomatiereassoc.DataSource = null;
                comboallclasses.DataSource = null;
                comboallmatieres.DataSource = null;
                comboclassassoc.DataSource = null;

                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                if (row != null)
                {
                    txtnomprof.Text = row.Cells[1].Value.ToString();
                    txtprenomprof.Text = row.Cells[2].Value.ToString();
                    txttelephoneprof.Text = row.Cells[3].Value.ToString();
                    txtemailprof.Text = row.Cells[4].Value.ToString();
                    btnajouterprof.Enabled = false;
                    btneffacerprof.Enabled = true;
                    btnmodifprof.Enabled = true;
                    btnsupprimerprof.Enabled = true;
                    txtprofchoisi.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                    refreshclassma();
                    RefreshClasseProf();
                   /* if (comboclassassoc.Items.Count > 0)
                    {
                        refreshmatieres((int)comboclassassoc.SelectedValue);
                    }*/
                }
            }
        }
        private void refreshclassma()
        {
            using (var db = new DB())
            {
                comboallclasses.DataSource = db.Classes.ToList();
                comboallclasses.DisplayMember = "NomClasse";
                comboallclasses.ValueMember = "Id";
            }
        }
        private void refreshmatieres(int idClasse)
        {
            using (var db = new DB())
            {
                var coursAvecMatieres = db.ClassesCours
                    .Where(cc => cc.IdClasse == idClasse) // Filtrer par classe
                    .Select(cc => new
                    {
                        Cours = cc.Cours, // Récupérer le cours
                        Matieres = cc.Cours.CoursMatieres.Select(cm => cm.Matiere).Distinct().ToList() // Récupérer les matières associées
                    })
                    .ToList();

                // Liste pour stocker toutes les matières uniques
                List<Matiere> matieresAssociees = new List<Matiere>();

                foreach (var item in coursAvecMatieres)
                {
                    matieresAssociees.AddRange(item.Matieres);
                }

                // Éviter les doublons
                matieresAssociees = matieresAssociees.Distinct().ToList();

                if (matieresAssociees.Any()) // Vérifier si la liste contient des éléments
                {
                    comboallmatieres.DataSource = null; // Réinitialisation pour éviter les bugs
                    comboallmatieres.DataSource = matieresAssociees;
                    comboallmatieres.DisplayMember = "NomMatiere"; // Assurez-vous que cette propriété existe
                    comboallmatieres.ValueMember = "Id";
                }
                else
                {
                    comboallmatieres.DataSource = null;
                    MessageBox.Show("Aucune matière trouvée pour cette classe.");
                }
            }
        }

        private void RefreshClasseProf()
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idprofesseur = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var db = new DB())
                {
                    // Charger la classe avec ses relations ProfesseurClasses
                    Professeur professeur = db.Professeurs
                        .Include("ProfesseursClasses.Classe") // Inclure les professeurs liés via la table de liaison
                        .FirstOrDefault(c => c.Id == idprofesseur);

                    if (professeur != null)
                    {
                        // Récupérer uniquement les professeurs associés
                        var professeursAssocies = professeur.ProfesseursClasses
                            .Select(pc => pc.Classe)
                            .ToList();

                        comboclassassoc.DataSource = professeursAssocies;
                        comboclassassoc.DisplayMember = "NomClasse"; // Assurez-vous que cette propriété existe
                        comboclassassoc.ValueMember = "Id";
                    }
                    else { 
                        comboclassassoc.DataSource = null;
                    }
                }
            }
        }
        private void RefreshMatieresProfesseur()
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idProfesseur = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var db = new DB())
                {
                   
                    Professeur professeur = db.Professeurs
                        .Include("ProfesseursMatieres.Matiere") // Inclure les professeurs liés via la table de liaison
                        .FirstOrDefault(c => c.Id == idProfesseur);

                    if (professeur != null)
                    {
                        // Récupérer les matières associées au professeur
                        var matieresAssociees = professeur.ProfesseursMatieres
                            .Select(pm => pm.Matiere)
                            .Distinct() // Éviter les doublons
                            .ToList();

                        // Mettre à jour le ComboBox
                        combomatiereassoc.DataSource = null; // Reset pour éviter les erreurs d'affichage
                        combomatiereassoc.DataSource = matieresAssociees;
                        combomatiereassoc.DisplayMember = "NomMatiere"; // Assurez-vous que cette propriété existe
                        combomatiereassoc.ValueMember = "Id";
                    }
                    else
                    {
                        combomatiereassoc.DataSource = null;
                        MessageBox.Show("Aucune matière trouvée pour ce professeur.");
                    }
                }
            }
        }


        private void btnsupprimerprof_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                int profid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Professeur prof = db.Professeurs.Find(profid);
                if (prof != null)
                {
                    if (verif_relation_prof_classe(profid) == 0) {
                        db.Professeurs.Remove(prof);
                        db.SaveChanges();
                        MessageBox.Show(" Professeur effacée");
                    }
                    else
                    {
                        MessageBox.Show(" Vous devez dissocier Prof et classe dabord");
                    }
                }
            }
            effacer();
            refresh();
        }
        private int verif_relation_prof_classe(int idprof)
        {
            int x = 0;
            using (var db = new DB())
            {
                x = db.ProfesseursClasses.Where(c=> c.IdProfesseur==idprof).Count();
            }
            return x;
        }
        private int verif_numero(string numero)
        {
            if (numero.Length == 9 && txttelephoneprof.Text.All(char.IsDigit) && numero[0] == '7' && numero[0] == '7' || numero[0] == '6' || numero[0] == '5' || numero[0] == '0')
            {
                return 0;
            }
            return 1;
        }
        private int existemail(string email)
        {
            int x = 0;
            using (var db = new DB())
            {
                x = db.Professeurs
                    .Where(o => o.Email == email)
                    .Select(o => o.Id)
                    .FirstOrDefault();
            }
            return x;
        }
        private int existnumero(string numero)
        {
            int x = 0;
            using (var db = new DB())
            {
                x = db.Professeurs
                   .Where(o => o.Telephone == numero)
                   .Select(o => o.Id)
                   .FirstOrDefault();
            }
            return x;
        }

        private void btnajouterprof_Click(object sender, EventArgs e)
        {
            if (txttelephoneprof.Text.Length > 0 && txtnomprof.Text.Length > 0
                && txtprenomprof.Text.Length > 0 && txtemailprof.Text.Length > 0)
            {
                //ajouter un professeur
                Professeur professeur = new Professeur();
                professeur.Telephone = txttelephoneprof.Text;
                professeur.Nom = txtnomprof.Text;
                professeur.Prenom = txtprenomprof.Text;
                professeur.Email = txtemailprof.Text;
                using (var db = new DB())
                {
                    db.Professeurs.Add(professeur);
                    db.SaveChanges();

                    MessageBox.Show(" Professeur ajoutée ");
                    refresh();

                }
            }
            else
            {
                MessageBox.Show("veuiller remplir toutes les cellules");
            }

        }

        private void txtemailprof_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtemailprof.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtemailprof, "email non valide");
            }
            else
            {
                if (existemail(txtemailprof.Text) != 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtemailprof, "numero deja existant");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtemailprof, "");
                }
            }

        }

        private void txttelephoneprof_Validating(object sender, CancelEventArgs e)
        {
            if (verif_numero(txttelephoneprof.Text) == 1)
            {
                e.Cancel = true;
                errorProvider1.SetError(txttelephoneprof, "numero non valide");
            }
            else
            {
                if (existnumero(txttelephoneprof.Text) != 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txttelephoneprof, "numero deja existant");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txttelephoneprof, "");
                }
            }
        }

        private void btnmodifprof_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                int profid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Professeur professeur = db.Professeurs.Find(profid);
                if (professeur != null)
                {
                    if (txttelephoneprof.Text.Length > 0 && txtnomprof.Text.Length > 0
                        && txtprenomprof.Text.Length > 0 && txtemailprof.Text.Length > 0)
                    {
                        professeur.Telephone = txttelephoneprof.Text;
                        professeur.Nom = txtnomprof.Text;
                        professeur.Prenom = txtprenomprof.Text;
                        professeur.Email = txtemailprof.Text;
                        db.SaveChanges();
                        MessageBox.Show(" Professeur Modifie");
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("veuiller remplir toutes les cellules");
                    }
                }
            }

            effacer();
            refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            recherch();
        }
        void recherch()
        {
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Professeurs
                       .Where(c => c.Nom.Contains(txtrecherch.Text))
                       .Select(c => new { c.Id, c.Nom, c.Prenom, c.Email, c.Telephone })
                        .ToList();
            }
        }

        private void txtallcours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void coboclassassoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboallmatieres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combomatiereassoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            combomatiereassoc.DataSource = null;
            comboallclasses.DataSource = null;
            comboallmatieres.DataSource = null;
            comboclassassoc.DataSource = null;
            txtprofchoisi.Text = string.Empty;
            txtrecherch.Text = string.Empty;
            refresh();
        }

        private void btnassocier_Click(object sender, EventArgs e)
        {
            // associer classe et professeur
            if (comboallclasses.Text.Length > 0 && txtprofchoisi.Text.Length > 0)
            {
                int idProf = (int)dataGridView1.CurrentRow.Cells[0].Value;
                int idClasse = (int)comboallclasses.SelectedValue;

                using (var db = new DB())
                {
                    // Vérifier si la relation existe déjà
                    bool relationExiste = db.ProfesseursClasses
                        .Any(pc => pc.IdProfesseur == idProf && pc.IdClasse == idClasse);

                    if (relationExiste)
                    {
                        MessageBox.Show("Cette relation entre la classe et le professeur existe déjà !");
                        return;
                    }

                    // Trouver les objets Professeur et Classe existants
                    Professeur professeur = db.Professeurs.Include("ProfesseursClasses").FirstOrDefault(p => p.Id == idProf);
                    Classe classe = db.Classes.Include("ProfesseursClasses").FirstOrDefault(c => c.Id == idClasse);

                    if (professeur != null && classe != null)
                    {
                        // Créer une nouvelle liaison Classe-Professeur
                        ProfesseurClasse professeurClasse = new ProfesseurClasse
                        {
                            Professeur = professeur,
                            Classe = classe,
                            IdProfesseur = professeur.Id,
                            IdClasse = classe.Id
                        };

                        // Ajouter la relation dans les collections
                        professeur.ProfesseursClasses.Add(professeurClasse);
                        classe.ProfesseursClasses.Add(professeurClasse);

                        // Ajouter à la base de données et sauvegarder
                        db.ProfesseursClasses.Add(professeurClasse);
                        db.SaveChanges();

                        MessageBox.Show("Professeur et Classe associés avec succès !");
                        btnannuler_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Professeur ou Classe introuvable !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur et une classe !");
            }


        }

        private void btndissocier_Click(object sender, EventArgs e)
        {
            if (comboclassassoc.Text.Length > 0 && txtprofchoisi.Text.Length > 0)
            {
                int idProf = (int)dataGridView1.CurrentRow.Cells[0].Value;
                int idClasse = (int)comboclassassoc.SelectedValue;

                using (var db = new DB())
                {
                    // Vérifier si la relation existe
                    var professeurClasse = db.ProfesseursClasses
                        .FirstOrDefault(pc => pc.IdProfesseur == idProf && pc.IdClasse == idClasse);

                    if (professeurClasse != null)
                    {
                        // Supprimer la relation de la base de données
                        db.ProfesseursClasses.Remove(professeurClasse);
                        db.SaveChanges();

                        MessageBox.Show("Dissociation réussie : le professeur n'est plus associé à cette classe.");
                        btnannuler_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Cette association entre le professeur et la classe n'existe pas !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur et une classe !");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboallmatieres.Text.Length > 0 && txtprofchoisi.Text.Length > 0)
            {
                int idProf = (int)dataGridView1.CurrentRow.Cells[0].Value;
                int idMatiere = (int)comboallmatieres.SelectedValue;
                int idClasse = (int)comboclassassoc.SelectedValue;

                using (var db = new DB())
                {
                    // Vérifier si la relation existe déjà
                    bool relationExiste = db.ProfesseursMatieres
                        .Any(a => a.IdProfesseur == idProf && a.IdMatiere == idMatiere);

                    if (relationExiste)
                    {
                        MessageBox.Show("Cette relation entre le professeur et la matière existe déjà !");
                        return;
                    }

                    // Vérifier si un autre professeur est déjà associé à cette matière dans cette classe
                    bool associationExiste = db.ProfesseursMatieres
                        .Any(pm => pm.IdMatiere == idMatiere &&
                                   db.ProfesseursClasses.Any(pc => pc.IdProfesseur == pm.IdProfesseur && pc.IdClasse == idClasse));

                    if (associationExiste)
                    {
                        MessageBox.Show("❌ Cette matière est déjà attribuée à un autre professeur dans cette classe !");
                        return;
                    }

                    // Récupérer le professeur et la matière
                    Professeur professeur = db.Professeurs.FirstOrDefault(p => p.Id == idProf);
                    Matiere matiere = db.Matieres.FirstOrDefault(m => m.Id == idMatiere);

                    if (professeur != null && matiere != null)
                    {
                        // Créer une nouvelle relation Professeur-Matière
                        var professeurMatiere = new ProfesseurMatiere
                        {
                            IdProfesseur = professeur.Id,
                            IdMatiere = matiere.Id,
                            Professeur = professeur,
                            Matiere = matiere
                        };

                        // Ajouter la relation dans la base de données et sauvegarder
                        db.ProfesseursMatieres.Add(professeurMatiere);
                        db.SaveChanges();

                        MessageBox.Show($"Association réussie : {professeur.Prenom} {professeur.Nom} est maintenant associé à {matiere.NomMatiere}.");
                        btnannuler_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Le professeur ou la matière est introuvable !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur et une matière !");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (combomatiereassoc.Text.Length > 0 && txtprofchoisi.Text.Length > 0)
            {
                int idProf = (int)dataGridView1.CurrentRow.Cells[0].Value;
                int idMatiere = (int)combomatiereassoc.SelectedValue;

                using (var db = new DB())
                {
                    // Vérifier si la relation existe
                    var professeurMatiere = db.ProfesseursMatieres
                        .FirstOrDefault(a => a.IdProfesseur == idProf && a.IdMatiere == idMatiere);

                    if (professeurMatiere != null)
                    {
                        // Supprimer la relation de la base de données
                        db.ProfesseursMatieres.Remove(professeurMatiere);
                        db.SaveChanges();

                        MessageBox.Show("Dissociation réussie : le professeur n'est plus associé à cette matière.");
                        btnannuler_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Cette association entre le professeur et la matière n'existe pas !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur et une matière !");
            }

        }

        private void comboclassassoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboclassassoc.Items.Count > 0)
            {
                refreshmatieres((int)comboclassassoc.SelectedValue);
                RefreshMatieresProfesseur();
            }
        }
    }
}
