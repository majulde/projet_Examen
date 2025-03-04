using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Gestion_d_ecole
{
    public partial class FormInscriptionUser : Form
    {
        public FormInscriptionUser()
        {
            InitializeComponent();
        }

        private void btnEnregistrerIns_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomUtilisateurIns.Text) ||
            string.IsNullOrWhiteSpace(txtPasswordIns.Text) ||
            string.IsNullOrWhiteSpace(txtTelephone.Text) ||
            cmbRole.SelectedIndex == -1) // Vérifie si un rôle a été sélectionné
                {
                    MessageBox.Show("Tous les champs sont obligatoires et vous devez choisir un rôle valide.");
                    return;
                }
                using (var db = new DB())
                {
                    try
                    {
                        // Vérifier si l'utilisateur existe déjà
                        if (db.Utilisateurs.Any(u => u.NomUtilisateur == txtNomUtilisateurIns.Text))
                        {
                            MessageBox.Show("Ce nom d'utilisateur est déjà pris. Veuillez en choisir un autre.");
                            return;
                        }


                        Utilisateur utilisateur = new Utilisateur
                        {
                            NomUtilisateur = txtNomUtilisateurIns.Text,
                            MotDePasse = BCrypt.Net.BCrypt.HashPassword(txtPasswordIns.Text), // Hachage du mot de passe
                            Telephone = txtTelephone.Text,
                            Role = cmbRole.Text 
                        };

                        db.Utilisateurs.Add(utilisateur);
                        db.SaveChanges();
                        MessageBox.Show("Utilisateur ajouté avec succès !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de l'ajout de l'utilisateur : {ex.Message}");
                    }
                }

            }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_Validating(object sender, CancelEventArgs e)
        {
            if (!cmbRole.Items.Contains(cmbRole.Text))
            {
                MessageBox.Show("Rôle invalide. Veuillez en sélectionner un dans la liste.");
                cmbRole.Focus();
                e.Cancel = true; // Annule la validation
            }
        }
    }

    }
