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
                    db.Professeurs.Remove(prof);
                    db.SaveChanges();
                    MessageBox.Show(" Classe effacée");
                }
            }
            effacer();
            refresh();
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
    }
}
