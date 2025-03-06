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
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            refreshclasse();
            //RefreshMatieres((int)txtclasse.SelectedValue);
            // refreshcours((int)txtclasse.SelectedValue);
            dataGridView1.DataSource = null;
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Etudiants
                .Where(p => p.Classe.NomClasse == txtclasse.Text)
                .Select(p => new viewEtudiant
                {
                    Id = p.Id,
                    Matricule = p.Matricule,
                    Nom = p.Nom,
                    Prenom = p.Prenom,
                    Sexe = p.Sexe,
                    DateNaissance = p.DateNaissance,
                    Adresse = p.Adresse,
                    Classe = p.Classe.NomClasse
                }).OrderBy(p => p.Nom).ToList();

            }
            txtetudiant.Text = "";
            txtnote.Text = "";
            txtnote.Enabled = false;
            btnvalider.Enabled = false;
        }
        private void refreshclasse()
        {
            using (var db = new DB())
            {
                txtclasse.DataSource = db.Classes.ToList();
                txtclasse.DisplayMember = "NomClasse";
                txtclasse.ValueMember = "Id";
            }
        }


        private void RefreshMatieres(int idClasse)
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
                    txtmatiere.DataSource = null; 
                    txtmatiere.DataSource = matieresAssociees;
                    txtmatiere.DisplayMember = "NomMatiere"; 
                    txtmatiere.ValueMember = "Id";
                }
                else
                {
                    txtmatiere.DataSource = null;
                    MessageBox.Show("Aucune matière trouvée pour cette classe.");
                }
            }
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { }


        private void txtclasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtclasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear(); // Efface toutes les colonnes existantes

            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Etudiants
                .Where(p => p.Classe.NomClasse == txtclasse.Text)
                .Select(p => new viewEtudiant
                {
                    Id = p.Id,
                    Matricule = p.Matricule,
                    Nom = p.Nom,
                    Prenom = p.Prenom,
                    Sexe = p.Sexe,
                    DateNaissance = p.DateNaissance,
                    Adresse = p.Adresse,
                    Classe = p.Classe.NomClasse
                }).OrderBy(p => p.Nom).ToList();
            }
            txtmatiere.DataSource = null;

            //RefreshMatieres((int)txtclasse.SelectedValue);
        }

        private void txtcours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtmatiere_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtetudiant.Text = row.Cells[3].Value.ToString() + " " + row.Cells[2].Value.ToString();
        }

        private void btnvoircours_Click(object sender, EventArgs e)
        {

        }

        private void btnvoirmatiere_Click(object sender, EventArgs e)
        {
            RefreshMatieres((int)txtclasse.SelectedValue);
        }

        private void btnvoircours_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnajouternote_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || txtmatiere.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant et une matière !");
            }
            else
            {
                if (verif_existe_note() >= 0)
                {
                    MessageBox.Show("La note existe déjà Mais vous pouvez la modifier ");
                    txtnote.Enabled = true;
                    txtnote.Text = verif_existe_note().ToString();
                }
                else
                {
                    txtnote.Enabled = true;
                }
                btnvalider.Enabled = true;
            }

        }
        private float verif_existe_note()
        {

            int idEtudiant = (int)dataGridView1.CurrentRow.Cells[0].Value;
            int idMatiere = (int)txtmatiere.SelectedValue;
            float x = -1000;
            using (var db = new DB())
            {
                x = db.Notes
                   .Where(p => p.IdEtudiant == idEtudiant && p.IdMatiere == idMatiere)
                   .Select(p => p.Id)
                   .FirstOrDefault();
                if (x != 0)
                {
                    return db.Notes.Where(p => p.IdEtudiant == idEtudiant && p.IdMatiere == idMatiere)
                    .Select(p => p.ValeurNote)
                    .FirstOrDefault();
                }
            }
            return -1;
        }


        private void btnvalider_Click(object sender, EventArgs e)
        {
            
                if (verif_existe_note() >= 0)
                {
                    int idEtudiant = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    int idMatiere = (int)txtmatiere.SelectedValue;
                    using (var db = new DB())
                    {
                        Note note = db.Notes.Where(p => p.IdEtudiant == idEtudiant && p.IdMatiere == idMatiere)
                        .FirstOrDefault();
                        note.ValeurNote = float.Parse(txtnote.Text);
                        db.SaveChanges();

                        MessageBox.Show("Note modifiée avec succès");
                        refresh();
                    }
                }
                else
                {
                    Note note = new Note();
                    note.IdEtudiant = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    note.IdMatiere = (int)txtmatiere.SelectedValue;
                    note.ValeurNote = float.Parse(txtnote.Text);
                    using (var db = new DB())
                    {
                        db.Notes.Add(note);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Note ajoutée avec succès");
                    refresh();
                }
           
            
        }
    }
}
