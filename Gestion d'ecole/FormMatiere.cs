using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_ecole
{
    public partial class FormMatiere : Form
    {
        public FormMatiere()
        {
            InitializeComponent();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (txtmatiere.Text.Length>0)
            {
                if (existcours(txtmatiere.Text)==0) 
                {
                    using (var db = new DB())
                    {
                        db.Matieres.Add(new Matiere { NomMatiere = txtmatiere.Text });
                        db.SaveChanges();
                    }
                    refresh();
                }
                else
                {
                    MessageBox.Show("Cette matiere existe deja");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir le champ");
            }
        }
        private void refresh()
        {
            dataGridView1.DataSource = null;
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Matieres.Select(c => new { c.Id, c.NomMatiere }).ToList();
            }
            //effacer();
            
        }

        private void FormMatiere_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private int existcours(string nom)
        {
            int x = 0;
            using (var db = new DB())
            {
                x = db.Matieres
                    .Where(o => o.NomMatiere == nom)
                    .Select(o => o.Id)
                    .FirstOrDefault();
            }
            return x;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtmatierechoisi.Text = row.Cells[1].Value.ToString();
            refreshcours();
            refreshcoursassoc();
        }
        private void refreshcours()
        {
            using (var db = new DB())
            {
                combocours.DataSource = db.Cours.ToList();
                combocours.DisplayMember = "NomCours";
                combocours.ValueMember = "Id";
            }
        }
        private void refreshcoursassoc()
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idMatiere = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var db = new DB())
                {
                    // Chargement de la matière avec ses relations CoursMatieres
                    Matiere matiere = db.Matieres
                        .Include("CoursMatieres.Cours") // Inclure les cours liés via la table de liaison
                        .FirstOrDefault(m => m.Id == idMatiere);

                    if (matiere != null)
                    {
                        // Récupérer uniquement les cours associés
                        var coursAssocies = matiere.CoursMatieres
                            .Select(p => p.Cours)
                            .ToList();

                        combodejaassocie.DataSource = coursAssocies;
                        combodejaassocie.DisplayMember = "NomCours"; // Assurez-vous que cette propriété existe
                        combodejaassocie.ValueMember = "Id";
                    }
                    
                }
            }
        }


        private void combocours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btneffacer_Click(object sender, EventArgs e)
        {
            refresh();
            //combocours.Items.Clear();
            txtmatiere.Text = string.Empty;
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            //refresh
            combocours.DataSource = null;
            combocours.Items.Clear();
            txtmatierechoisi.Text = string.Empty;
        }

        private void btnassocier_Click(object sender, EventArgs e)
        {
            if (combocours.Text.Length > 0 && txtmatierechoisi.Text.Length > 0)
            {
                int idCours = (int)combocours.SelectedValue;
                int idMatiere = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var db = new DB())
                {
                    // Vérifier si la relation existe déjà
                    bool relationExiste = db.CoursMatieres
                        .Any(cm => cm.IdCours == idCours && cm.IdMatiere == idMatiere);

                    if (relationExiste)
                    {
                        MessageBox.Show("Cette relation entre le cours et la matière existe déjà !");
                        return;
                    }

                    // Trouver les objets Cours et Matiere existants
                    Cours cours = db.Cours.Include("CoursMatieres").FirstOrDefault(c => c.Id == idCours);
                    Matiere matiere = db.Matieres.Include("CoursMatieres").FirstOrDefault(m => m.Id == idMatiere);

                    if (cours != null && matiere != null)
                    {
                        // Créer une nouvelle liaison Cours-Matière
                        CoursMatiere coursmatiere = new CoursMatiere
                        {
                            Cours = cours,
                            Matiere = matiere,
                            IdCours = cours.Id,
                            IdMatiere = matiere.Id
                        };

                        // Ajouter la relation dans les collections
                        cours.CoursMatieres.Add(coursmatiere);
                        matiere.CoursMatieres.Add(coursmatiere);

                        // Ajouter à la base de données et sauvegarder
                        db.CoursMatieres.Add(coursmatiere);
                        db.SaveChanges();

                        MessageBox.Show("Cours et Matière associés avec succès !");
                        btnannuler_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Cours ou Matière introuvable !");
                    }
                }
            }
            else
            {
                    MessageBox.Show("Veuillez selectionner une matiere et un cours");
            }

        }

        private void combodejaassocie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btndissocier_Click(object sender, EventArgs e)
        {
            if (combodejaassocie.Text.Length > 0 && dataGridView1.CurrentRow != null)
            {
                int idCours = (int)combodejaassocie.SelectedValue;
                int idMatiere = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var db = new DB())
                {
                    // Vérifier si la relation existe
                    var coursMatiere = db.CoursMatieres
                        .FirstOrDefault(p => p.IdCours == idCours && p.IdMatiere == idMatiere);

                    if (coursMatiere != null)
                    {
                        // Supprimer la relation
                        db.CoursMatieres.Remove(coursMatiere);
                        db.SaveChanges();

                        MessageBox.Show("Association supprimée avec succès !");
                        btnannuler_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Cette relation n'existe pas !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une matière et un cours à dissocier !");
            }

        }
    }
}
