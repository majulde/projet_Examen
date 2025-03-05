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
        private void refreshcours()
        {
            using (var db = new DB())
            {
               /* txtclasse.DataSource = db.Cours.Where(p => p.c).ToList();
                txtclasse.DisplayMember = "NomClasse";
                txtclasse.ValueMember = "Id";*/
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
    }
}
