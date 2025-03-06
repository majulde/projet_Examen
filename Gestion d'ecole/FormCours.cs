using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Gestion_d_ecole
{
    public partial class FormCours : Form
    {
        public FormCours()
        {
            InitializeComponent();
        }

        private void FormCours_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            effacer();
            dataGridView1.DataSource = null;
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Cours.Select(c => new { c.Id, c.NomCours, c.Description, })
                                                   .ToList();
            }
            
            btnajouter.Enabled = true;
            btneffacer.Enabled = false;
            btnmodifier.Enabled = false;
            btnsupprimer.Enabled = false;
        }
        private void effacer()
        {
            txtnomcours.Text = string.Empty;
            txtdescription.Text = string.Empty;
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

        private int existcours(string nom)
        {
            int x = 0;
            using (var db = new DB())
            {
                x = db.Cours
                    .Where(o => o.NomCours == nom)
                    .Select(o => o.Id)
                    .FirstOrDefault();
            }
            return x;
        }

        private void txtnomcours_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtnomcours_TextChanged(object sender, EventArgs e)
        {
            if (txtdescription.Text.Length > 0 || txtnomcours.Text.Length>0)
            {
                btneffacer.Enabled = true;
            }
            else
            {
                btneffacer.Enabled = false;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtnomcours.Text = row.Cells[1].Value.ToString();
            txtdescription.Text = row.Cells[2].Value.ToString();
            btnajouter.Enabled = false;
            btneffacer.Enabled = true;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                int coursId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Cours cours = db.Cours.Find(coursId);
                if (cours != null)
                {
                    if (verif_relation_cours(coursId) == 0)
                    {
                        db.Cours.Remove(cours);
                        db.SaveChanges();
                        MessageBox.Show(" Cours  effacé");
                    }
                    else
                    {
                        MessageBox.Show(" Faut dabord dissocier Ce cours a tous les classes et matieres liess");
                    }
                }
            }
            effacer();
            refresh();
        }
        private int verif_relation_cours(int coursId) { 
            int x = 0;
            using (var db = new DB())
            {
                x = db.ClassesCours.Where(c => c.IdCours == coursId).Count()
                    + db.CoursMatieres.Where(c => c.IdCours == coursId).Count();
            }
            return x;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (txtdescription.Text.Length > 0 && txtnomcours.Text.Length > 0)
            {
                if (existcours(txtnomcours.Text) == 0)
                {
                    using (var db = new DB())
                    {
                        Cours cours = new Cours();
                        cours.NomCours = txtnomcours.Text;
                        cours.Description = txtdescription.Text;
                        db.Cours.Add(cours);
                        db.SaveChanges();
                        MessageBox.Show(" cours ajoutée ");
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
                MessageBox.Show("veuiller remplir toutes ces pages");
            }

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                int coursId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Cours cours = db.Cours.Find(coursId);
                if (existcours(txtnomcours.Text) == 0)
                {
                    if (cours != null)
                    {
                        if (txtnomcours.Text.Length > 0 && txtdescription.Text.Length > 0)
                        {
                            cours.NomCours = txtnomcours.Text;
                            cours.Description = txtdescription.Text;
                            db.SaveChanges();
                            MessageBox.Show(" Cours Modifié");
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show(" Remplir les cellules vides");
                        }
                    }
                }
                else
                {
                    if (txtnomcours.Text == cours.NomCours)
                    {
                        cours.NomCours = txtnomcours.Text;
                        cours.Description = txtdescription.Text;
                        db.SaveChanges();
                        MessageBox.Show(" Cours Modifié");
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show(" Cours deja deja existant");
                    }
                }
            }
        }
    }
}
