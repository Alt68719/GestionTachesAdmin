using System;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;
using GestionTachesAdmin.Forms;

namespace GestionTachesAdmin
{
  
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string identifiant = txtIdentifiant.Text.Trim();
            string mdp = txtMotDePasse.Text;

            if (string.IsNullOrEmpty(identifiant) || string.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (identifiant == "Admin" && mdp == "Password")
            {
                MessageBox.Show("Bienvenue Administrateur !", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuPrincipal adminForm = new FormMenuPrincipal();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                AuthDAO authDAO = new AuthDAO();
                if (authDAO.VerifierEmploye(identifiant, mdp))
                {
                    MessageBox.Show($"Bienvenue Employé {identifiant} !", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenuEmploye employeForm = new FormMenuEmploye(identifiant);
                    employeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }       
}