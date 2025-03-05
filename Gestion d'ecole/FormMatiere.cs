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
            //combocours.Items.Clear();
            txtmatierechoisi.Text = string.Empty;
        }

        private void btnassocier_Click(object sender, EventArgs e)
        {
            if (combocours.Text.Length > 0 && txtmatierechoisi.Text.Length > 0)
            {

                int idCours = (int)combocours.SelectedValue;
                int idMatiere = (int)dataGridView1.CurrentRow.Cells[0].Value;
                //ajouter un coursmatiere
                /*using (var db = new DB())
                {
                    CoursMatiere coursmatiere = new CoursMatiere();

                    Cours cours = db.Cours.Find(combocours.SelectedValue);
                    coursmatiere.Cours = cours;

                    Matiere matiere = db.Matieres.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
                    coursmatiere.Matiere = matiere;
                    db.CoursMatieres.Add(coursmatiere);
                    db.SaveChanges();
                    MessageBox.Show("Cours associé");
                    
                }*/
                if (existcoursmatiere(idCours,idMatiere)==0) {
                try
                {
                    using (var db = new DB())
                    {
                        var coursMatiere = new CoursMatiere
                        {
                            IdCours = idCours,
                            IdMatiere = idMatiere
                        };

                        db.CoursMatieres.Add(coursMatiere);
                        db.SaveChanges();
                        MessageBox.Show("Cours associé");
                        btnannuler_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception (journaliser, afficher un message, etc.)
                    Console.WriteLine($"Une erreur est survenue : {ex.Message}");
                }
                }
                else { MessageBox.Show("Cours deja associé"); }
            }
                else
                {
                    MessageBox.Show("Veuillez selectionner une matiere et un cours");
                }

        }
        private int existcoursmatiere(int idcours, int idmatiere)
        {
            int x = 0;
            using (var db = new DB())
            {
                x = db.CoursMatieres
                    .Where(o => o.IdCours == idcours && o.IdMatiere == idmatiere)
                    .Select(o => o.IdCours)
                    .FirstOrDefault();
            }
            return x;
        }

    }
}
