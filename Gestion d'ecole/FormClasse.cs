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
            btnajouter.Enabled = false;
            btneffacer.Enabled = true;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;
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
                        db.Classes.Remove(classe);
                        db.SaveChanges();
                        MessageBox.Show(" Classe effacée");
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
    }
}
