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
    public partial class FormEtudiant : Form
    {
        public FormEtudiant()
        {
            InitializeComponent();
        }

        private void FormEtudiant_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            dataGridView1.DataSource = null;
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Etudiants
                .Select(p => new viewEtudiant
                {
                    Id = p.Id,
                    Matricule = p.Matricule,
                    Nom = p.Nom,
                    Prenom = p.Prenom,
                    Email = p.Email,
                    Telephone = p.Telephone,
                    Sexe = p.Sexe,
                    DateNaissance = p.DateNaissance,
                    Adresse = p.Adresse,
                    Classe = p.Classe.NomClasse

               }).ToList();

            }
            
            effacer();
            btnetudiantajouter.Enabled = true;
           
        }

        private void refreshdate()
        {
            txtetudiantdatenais.MinDate = new DateTime(1990, 1, 1); 
            txtetudiantdatenais.MaxDate = new DateTime(2020, 12, 31);
        }
        private void refreshclasse()
        {
            using (var db = new DB())
            {
                txtetudiantclasse.DataSource = db.Classes.ToList();
                txtetudiantclasse.DisplayMember = "NomClasse";
                txtetudiantclasse.ValueMember = "Id";
            }
        }
        private void refreshsexe()
        {
            //txtetudiantsexe.Items.Clear();
            txtetudiantsexe.DataSource = mes_sexe;
        }
        private void refreshfiltre()
        {
            using (var db = new DB())
            {
                txtfiltre.Text = string.Empty;
                txtfiltre.DataSource = db.Classes.ToList();
                txtfiltre.DisplayMember = "NomClasse";
                txtfiltre.SelectedIndex = -1;
            }
        }



        private void btnetudianteffacer_Click(object sender, EventArgs e)
        {
            effacer();
        }
        private void effacer()
        {
            txtetudiantnom.Text = string.Empty;
            txtetudiantprenom.Text = string.Empty;
            txtetudiantemail.Text = string.Empty;
            txtetudiantadresse.Text = string.Empty;
            txtetudianttelephone.Text = string.Empty;
            refreshdate();
            refreshclasse();
            refreshfiltre();
            refreshsexe();
            btnetudiantajouter.Enabled = false;
            btnetudianteffacer.Enabled = false;
            btnetudiantmodifier.Enabled = false;
            btnetudiantsupprimer.Enabled = false;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            if (row != null)
            {
                txtetudiantnom.Text = row.Cells[2].Value.ToString();
                txtetudiantprenom.Text = row.Cells[3].Value.ToString();
                DateTime dateNaissance;
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out dateNaissance))
                {
                    txtetudiantdatenais.Value = dateNaissance; // Assignation réussie
                }
                //txtetudiantdatenais.Value = row.Cells[4].Value.ToString();
                txtetudiantsexe.Text = row.Cells[5].Value.ToString();
                txtetudiantadresse.Text = row.Cells[6].Value.ToString();
                txtetudianttelephone.Text = row.Cells[7].Value.ToString();
                txtetudiantemail.Text = row.Cells[8].Value.ToString();

                btnetudiantajouter.Enabled = false;
                btnetudianteffacer.Enabled = true;
                btnetudiantmodifier.Enabled = true;
                btnetudiantsupprimer.Enabled = true;
            }
        }

        private void btnetudiantajouter_Click(object sender, EventArgs e)
        {
            if (txtetudiantadresse.Text.Length>0 && txtetudiantnom.Text.Length>0
                && txtetudiantprenom.Text.Length > 0 && txtetudianttelephone.Text.Length > 0
                && txtetudiantemail.Text.Length > 0)
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Nom = txtetudiantnom.Text;
                etudiant.Prenom = txtetudiantprenom.Text;
                etudiant.Adresse = txtetudiantadresse.Text;
                etudiant.Sexe = txtetudiantsexe.Text;
                etudiant.DateNaissance = txtetudiantdatenais.Value;
                etudiant.Classe = (Classe)txtetudiantclasse.SelectedItem;
                etudiant.Telephone = txtetudianttelephone.Text; etudiant.Email = txtetudiantemail.Text;
                etudiant.Matricule = getlastid()+txtetudianttelephone.Text.Substring(0, 2)+txtetudiantnom.Text.Substring(0, 2);
                using (var db = new DB())
                {
                    db.Etudiants.Add(etudiant);
                    db.SaveChanges();

                    MessageBox.Show(" Classe ajoutée ");
                    refresh();

                }
            } else
            {
                 MessageBox.Show("veuiller remplir toutes les cellules");
            }
        }

        private void btnetudiantsupprimer_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                int etudiantId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Etudiant etudiant = db.Etudiants.Find(etudiantId);
                if (etudiant != null)
                {
                    supprimer(etudiantId);
                    db.Etudiants.Remove(etudiant);
                    db.SaveChanges();
                    MessageBox.Show(" Classe effacée");
                    refresh();
                }
            }
        }
        void supprimer(int id)
        {
            using (var db = new DB())
            {
                var notes = db.Notes.Where(n => n.IdEtudiant == id).ToList();
                foreach (var note in notes)
                {
                    db.Notes.Remove(note);
                }
            }
        }
        private int verif_numero(string numero)
        {
            if (numero.Length == 9 && txtetudianttelephone.Text.All(char.IsDigit) && numero[0] == '7' && numero[0] == '7' || numero[0] == '6' || numero[0] == '5' || numero[0] == '0')
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
                x = db.Etudiants
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
                x = db.Etudiants
                   .Where(o => o.Telephone == numero)
                   .Select(o => o.Id)
                   .FirstOrDefault();
            }
            return x;
        }

        private void txtetudianttelephone_Validating(object sender, CancelEventArgs e)
        {
            if (verif_numero(txtetudianttelephone.Text) == 1 )
            {
                e.Cancel = true;
                errorProvider1.SetError(txtetudianttelephone, "numero non valide");
            }
            else
            {
                if (existnumero(txtetudianttelephone.Text) != 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtetudianttelephone, "numero deja existant");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtetudianttelephone, "");
                }
            }
        }

        private void txtetudiantemail_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtetudiantemail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtetudiantemail,"email non valide");
            }
            else
            {
                if (existemail(txtetudiantemail.Text) != 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtetudiantemail, "numero deja existant");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtetudiantemail, "");
                }
            }
        }
        List<string> mes_sexe = new List<string> { "masculin", "feminin"};
        List<string> mes_classes;

        public void recharge() {
            using (var db = new DB())
            {
                mes_classes = db.Classes.Select(c => c.NomClasse).ToList(); // Sélectionnez directement la propriété
            }
        }




private void txtetudiantsexe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtetudiantsexe_Validating(object sender, CancelEventArgs e)
        {
            if (mes_sexe.Contains(txtetudiantsexe.Text) == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtetudiantsexe,"vous devez choisir parmi la liste deroulante");
            }
            else
            {
                errorProvider1.SetError(txtetudiantsexe, "");
                e.Cancel = false;
            }

        }

        private void txtetudiantclasse_Validating(object sender, CancelEventArgs e)
        {
            /*recharge();
            if (mes_classes.Contains(txtetudiantclasse.Text) == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtetudiantclasse, "vous devez choisir parmi la liste deroulante");
            }
            else
            {
                errorProvider1.SetError(txtetudiantclasse, "");
                e.Cancel = false;
            }*/
        }

        private void txtetudiantclasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private int getlastid()
        {
            using (var db = new DB())
            {
                var dernierId = db.Etudiants
                                  .OrderByDescending(e => e.Id).Select(e => e.Id) 
                                  .FirstOrDefault();

                return dernierId; // Retourner le dernier ID
            }
        }

        private void txtetudiantsexe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

       
        private void txtetudiantrecherch_TextChanged(object sender, EventArgs e)
        {
            if (txtetudiantrecherch.Text.Length > 0)
            {
                dataGridView1.DataSource = null;
                recherch();
            }
            else
            {
                refresh();
            }
        }
        void recherch()
        {
            using (var db = new DB())
            {
                switch (txtetudianttyperecherch.Text)
                {
                    case "nom":
                        dataGridView1.DataSource = db.Etudiants
                                    .Where(c => c.Nom.Contains(txtetudiantrecherch.Text))
                                    .Select(p => new viewEtudiant
                                    {
                                        Id = p.Id,
                                        Matricule = p.Matricule,
                                        Nom = p.Nom,
                                        Prenom = p.Prenom,
                                        Email = p.Email,
                                        Telephone = p.Telephone,
                                        Sexe = p.Sexe,
                                        DateNaissance = p.DateNaissance,
                                        Adresse = p.Adresse,
                                        Classe = p.Classe.NomClasse

                                    })
                                    .ToList();
                        break;
                    case "matricule":
                        dataGridView1.DataSource = db.Etudiants
                                    .Where(c => c.Matricule.Contains(txtetudiantrecherch.Text))
                                    .Select(p => new viewEtudiant
                                    {
                                        Id = p.Id,
                                        Matricule = p.Matricule,
                                        Nom = p.Nom,
                                        Prenom = p.Prenom,
                                        Email = p.Email,
                                        Telephone = p.Telephone,
                                        Sexe = p.Sexe,
                                        DateNaissance = p.DateNaissance,
                                        Adresse = p.Adresse,
                                        Classe = p.Classe.NomClasse

                                    })
                                    .ToList();
                        break;
                    case "classe":
                        dataGridView1.DataSource = db.Etudiants
                                    .Where(c => c.Classe.NomClasse.Contains(txtetudiantrecherch.Text))
                                    .Select(p => new viewEtudiant
                                    {
                                        Id = p.Id,
                                        Matricule = p.Matricule,
                                        Nom = p.Nom,
                                        Prenom = p.Prenom,
                                        Email = p.Email,
                                        Telephone = p.Telephone,
                                        Sexe = p.Sexe,
                                        DateNaissance = p.DateNaissance,
                                        Adresse = p.Adresse,
                                        Classe = p.Classe.NomClasse

                                    })
                                    .ToList();
                        break;
                }

            }
        }
        private void txtetudianttyperecherch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true ;
        }

        private void btnfiltrer_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Etudiants
                                                        .Where(c => c.Classe.NomClasse.Contains(txtfiltre.Text))
                                                        .Select(p => new viewEtudiant
                                                        {
                                                            Id = p.Id,
                                                            Matricule = p.Matricule,
                                                            Nom = p.Nom,
                                                            Prenom = p.Prenom,
                                                            Email = p.Email,
                                                            Telephone = p.Telephone,
                                                            Sexe = p.Sexe,
                                                            DateNaissance = p.DateNaissance,
                                                            Adresse = p.Adresse,
                                                            Classe = p.Classe.NomClasse

                                                        })
                                                        .ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void txtetudianttyperecherch_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void txtetudianttyperecherch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            recherch();
        }

        private void btnetudiantmodifier_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                int etudiantId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Etudiant etudiant = db.Etudiants.Find(etudiantId);

                if (etudiant != null)
                {
                    if (txtetudiantadresse.Text.Length > 0 && txtetudiantnom.Text.Length > 0
                && txtetudiantprenom.Text.Length > 0 && txtetudianttelephone.Text.Length > 0
                && txtetudiantemail.Text.Length > 0)
                    {
                        
                        etudiant.Nom = txtetudiantnom.Text;
                        etudiant.Prenom = txtetudiantprenom.Text;
                        etudiant.Adresse = txtetudiantadresse.Text;
                        etudiant.Sexe = txtetudiantsexe.Text;
                        etudiant.DateNaissance = txtetudiantdatenais.Value;
                        etudiant.Classe = (Classe)txtetudiantclasse.SelectedItem;
                        etudiant.Telephone = txtetudianttelephone.Text;
                        etudiant.Email = txtetudiantemail.Text;
                        etudiant.Matricule = etudiantId + txtetudianttelephone.Text.Substring(0, 2) + txtetudiantnom.Text.Substring(0, 2);

                        db.SaveChanges();
                    MessageBox.Show(" Etudiant Modifiée");
                    refresh();
                    }
                    else
                    {
                        MessageBox.Show("veuiller remplir toutes les cellules");
                    }
                }
            }
        }

        private void txtfiltre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*
if (!Regex.IsMatch(textEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
{
MessageBox.Show("Adresse email invalide.");
return;
}
*/

    }
}
