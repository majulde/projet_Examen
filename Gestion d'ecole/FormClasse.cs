using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_ecole
{
    public partial class FormClasse : Form
    {
        public FormClasse()
        {
            InitializeComponent();
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            dataGridView1.DataSource = null;
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Classes.Select(c => new { c.Id, c.NomClasse }).ToList();
            }
            effacer();
            btnajouter.Enabled = true;
            btneffacer.Enabled = false;
            btnmodifier.Enabled = false;
            btnsupprimer.Enabled = false;
        }

        private void btneffacer_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            effacer();
        }
        private void effacer()
        {
            txtclassenom.Text = string.Empty;
            btnajouter.Enabled = true;
            btneffacer.Enabled = false;
            btnmodifier.Enabled = false;
            btnsupprimer.Enabled = false;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtclassenom.Text = row.Cells[1].Value.ToString();
            txtClassechoisi.Text = row.Cells[1].Value.ToString();
            btnajouter.Enabled = false;
            btneffacer.Enabled = true;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;
            refreshcoursassoc();
            refreshcours();
        }
        private void refreshcours()
        {
            using (var db = new DB())
            {
                comboallcours.DataSource = db.Cours.ToList();
                comboallcours.DisplayMember = "NomCours";
                comboallcours.ValueMember = "Id";
            }
        }
        private void refreshcoursassoc()
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idClasse = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var db = new DB())
                {
                    // Charger la classe avec ses relations ClasseCours
                    Classe classe = db.Classes
                        .Include("ClassesCours.Cours") // Inclure les cours liés via la table de liaison
                        .FirstOrDefault(c => c.Id == idClasse);

                    if (classe != null)
                    {
                        // Récupérer uniquement les cours associés
                        var coursAssocies = classe.ClassesCours
                            .Select(cc => cc.Cours)
                            .ToList();

                        combocoursassoc.DataSource = coursAssocies;
                        combocoursassoc.DisplayMember = "NomCours"; // Assurez-vous que cette propriété existe
                        combocoursassoc.ValueMember = "Id";
                    }
                    else
                    {
                        MessageBox.Show("Aucune classe trouvée !");
                    }
                }
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                int classeId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Classe classe = db.Classes.Find(classeId);
                if (verifier_si_classe_a_des_eleves(classe.NomClasse) == 0) 
                {
                    if (classe != null)
                    {
                        if (verif_relation_Classe(classeId) == 0)
                        {
                            db.Classes.Remove(classe);
                            db.SaveChanges();
                            MessageBox.Show(" Classe effacée");
                        }
                        else
                        {
                            MessageBox.Show("Faut d'abord dissocier Cette classe avec les profs et cours lies");
                        }
                        effacer();
                        refresh();
                    }
                }
                else
                {
                    MessageBox.Show(" Cette classe a des eleves vous devez d'abod les supprimer");
                }

            }
                 
        }
        private int verif_relation_Classe(int classeid)
        {
            int x = 0;
            using (var db = new DB())
            {
                x = db.ClassesCours.Where(c => c.IdClasse == classeid).Count()
                    + db.ProfesseursClasses.Where(c => c.IdClasse == classeid).Count();
            }
            return x;
        }
        private int verifier_si_classe_a_des_eleves(string nom)
        {
            using (var db = new DB())
            {
                var x = db.Etudiants
                       .Where(c => c.Classe.NomClasse==nom)
                       .FirstOrDefault();
                return x != null ? 1 : 0; 
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (txtclassenom.Text != string.Empty)
            {
                if (existclasse(txtclassenom.Text) == 0)
                {
                    using (var db = new DB())
                    {
                        Classe classe = new Classe();
                        classe.NomClasse = txtclassenom.Text;
                        db.Classes.Add(classe);
                        db.SaveChanges();

                        MessageBox.Show(" Classe ajoutée ");
                        refresh();

                    }
                }
                else
                {
                    MessageBox.Show("cette Classe exite deja");
                }
            }
            else
            {
                MessageBox.Show("veuiller saisir quellque chose");
            }

        }
        private int existclasse(string nom)
        {
            int x = 0;
            using (var db = new DB())
            {
                x = db.Classes
                    .Where(o => o.NomClasse == nom)
                    .Select(o => o.Id)
                    .FirstOrDefault();
            }
            return x;
        }

        private void txtclassenom_TextChanged(object sender, EventArgs e)
        {
 
                
                if (txtclassenom.Text.Length > 0)
                {
                    btneffacer.Enabled = true;
                }
                else
                {
                    btneffacer.Enabled = false;
                }
            
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                int classeId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Classe classe = db.Classes.Find(classeId);
                if (existclasse(txtclassenom.Text) == 0)
                {
                    if (classe != null)
                    {
                        if(txtclassenom.Text.Length >0)
                        {
                            classe.NomClasse = txtclassenom.Text;
                            db.SaveChanges();
                            MessageBox.Show(" Classe Modifiée");
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show(" Classe vide");
                        }
                    }
                }else
                 {
                    if (txtclassenom.Text == classe.NomClasse) {
                        classe.NomClasse = txtclassenom.Text;
                        db.SaveChanges();
                        MessageBox.Show(" Classe Modifiée");
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show(" Classe deja existant");
                    }
                 }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        recherch();
        }
        void recherch()
        {
            using (var db = new DB())
            {
            dataGridView1.DataSource = db.Classes
                   .Where(c => c.NomClasse.Contains(txtrecherch.Text))
                   .Select(c => new { c.Id, c.NomClasse })
                    .ToList();
            }
        }

        private void btnassocier_Click(object sender, EventArgs e)
        {
            if (comboallcours.Text.Length > 0 && txtClassechoisi.Text.Length > 0)
            {
                int idCours = (int)comboallcours.SelectedValue;
                int idClasse = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var db = new DB())
                {
                    // Vérifier si la relation existe déjà
                    bool relationExiste = db.ClassesCours
                        .Any(cc => cc.IdCours == idCours && cc.IdClasse == idClasse);

                    if (relationExiste)
                    {
                        MessageBox.Show("Cette relation entre la classe et le cours existe déjà !");
                        return;
                    }

                    // Trouver les objets Cours et Classe existants
                    Cours cours = db.Cours.Include("ClassesCours").FirstOrDefault(c => c.Id == idCours);
                    Classe classe = db.Classes.Include("ClassesCours").FirstOrDefault(cl => cl.Id == idClasse);

                    if (cours != null && classe != null)
                    {
                        // Créer une nouvelle liaison Classe-Cours
                        ClasseCours classeCours = new ClasseCours
                        {
                            Cours = cours,
                            Classe = classe,
                            IdCours = cours.Id,
                            IdClasse = classe.Id
                        };

                        // Ajouter la relation dans les collections
                        cours.ClassesCours.Add(classeCours);
                        classe.ClassesCours.Add(classeCours);

                        // Ajouter à la base de données et sauvegarder
                        db.ClassesCours.Add(classeCours);
                        db.SaveChanges();

                        MessageBox.Show("Cours et Classe associés avec succès !");
                        button2_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Cours ou Classe introuvable !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une matiere et un cours");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtClassechoisi.Text = string.Empty;
            comboallcours.DataSource = null;
            combocoursassoc.DataSource = null;
            refresh();
        }

        private void btndissocier_Click(object sender, EventArgs e)
        {
            if (comboallcours.Text.Length > 0 && txtClassechoisi.Text.Length > 0)
            {
                int idCours = (int)comboallcours.SelectedValue;
                int idClasse = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var db = new DB())
                {
                    // Vérifier si la relation existe
                    ClasseCours classeCours = db.ClassesCours
                        .FirstOrDefault(cc => cc.IdCours == idCours && cc.IdClasse == idClasse);

                    if (classeCours != null)
                    {
                        // Supprimer la relation de la base de données
                        db.ClassesCours.Remove(classeCours);
                        db.SaveChanges();

                        MessageBox.Show("Cours et Classe dissociés avec succès !");
                        button2_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Aucune association trouvée entre ce cours et cette classe !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe et un cours.");
            }

        }

        private void comboallcours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
