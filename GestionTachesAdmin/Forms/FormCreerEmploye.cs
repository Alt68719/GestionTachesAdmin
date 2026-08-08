using System;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;

namespace GestionTachesAdmin
{
    public partial class FormCreationEmploye : Form
    {
        public FormCreationEmploye()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string matricule = txtMatricule.Text.Trim();
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string poste = txtPoste.Text.Trim();

            // Récupération de la saisie du mot de passe
            string motDePasse = txtMotDePasse.Text.Trim();

            // Ajout de la vérification pour le mot de passe
            if (string.IsNullOrEmpty(matricule) || string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(poste) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Un ou plusieurs champs sont vides.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Appel du DAO avec le 5ème paramètre
                bool success = EmployeDAO.CreerEmploye(matricule, nom, prenom, poste, motDePasse);

                if (success)
                {
                    MessageBox.Show("Employé créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatricule.Clear();
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtPoste.Clear();
                    txtMotDePasse.Clear(); // On vide aussi ce champ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la création de l'employé : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}