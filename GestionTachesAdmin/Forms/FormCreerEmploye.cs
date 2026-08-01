using System;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;

namespace GestionTachesAdmin // Le namespace est maintenant identique
{
    public partial class FormCreationEmploye : Form // Le nom est maintenant identique
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

            if (string.IsNullOrEmpty(matricule) || string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(poste))
            {
                MessageBox.Show("Un champ est vide", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = EmployeDAO.CreerEmploye(matricule, nom, prenom, poste);
                if (success)
                {
                    MessageBox.Show("Employé créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatricule.Clear();
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtPoste.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la création de l'employé : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}