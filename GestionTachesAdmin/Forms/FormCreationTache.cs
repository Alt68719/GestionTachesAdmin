using System;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;
using System.Drawing;

namespace GestionTachesAdmin
{
    public partial class FormCreationTache : Form
    {
        private TacheDAO tacheDAO;
        private string priorite;

        public FormCreationTache()
        {
            InitializeComponent();
            tacheDAO = new TacheDAO();
        }

        // Cette méthode doit impérativement exister pour correspondre au Designer !
        private void btnCreer_Click(object sender, EventArgs e)
        {
            string titre = txtTitre.Text.Trim();
            string description = txtDescription.Text.Trim();
            string priorite = cmbPriorite.Text.Trim();
            DateTime dateLimite = dtpDateLimite.Value;

            if (string.IsNullOrEmpty(titre))
            {
                MessageBox.Show("Veuillez saisir un titre pour la tâche.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitre.Focus();
                return;
            }

            try
            {
                bool succes = tacheDAO.AjouterTache(titre, description, priorite, dateLimite);

                if (succes)
                {
                    MessageBox.Show($"La tâche '{titre}' a été créée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitre.Clear();
                    txtDescription.Clear();
                    dtpDateLimite.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Échec de la création de la tâche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur système : " + ex.Message, "Exception BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}