using System;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;

namespace GestionTachesAdmin
{
    public partial class FormCreationEmploye : Form
    {
        private EmployeDAO employeDAO;
        private bool modeModification;
        private string matriculeOriginal;
        public FormCreationEmploye()
        {
            InitializeComponent();
            employeDAO = new EmployeDAO();
            modeModification = false;
            matriculeOriginal = "";
        ChargerEmployes();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string matricule = txtMatricule.Text.Trim();
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string poste = txtPoste.Text.Trim();
            string motDePasse = txtMotDePasse.Text.Trim();

            if (string.IsNullOrEmpty(matricule) || string.IsNullOrEmpty(nom) ||
                string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(poste))
            {
                MessageBox.Show("Un ou plusieurs champs sont vides.", "Champ requis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success;

                if (modeModification)
                {
                    success = employeDAO.ModifierEmploye(matriculeOriginal, nom, prenom, poste, motDePasse);
                    if (success)
                        MessageBox.Show("Employé modifié avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (string.IsNullOrEmpty(motDePasse))
                    {
                        MessageBox.Show("Le mot de passe est requis pour créer un employé.", "Champ requis",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    success = EmployeDAO.CreerEmploye(matricule, nom, prenom, poste, motDePasse);
                    if (success)
                        MessageBox.Show("Employé créé avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (success)
                {
                    ReinitialiserFormulaire();
                    ChargerEmployes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReinitialiserFormulaire()
        {
            txtMatricule.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtPoste.Clear();
            txtMotDePasse.Clear();
            txtMatricule.Enabled = true;
            modeModification = false;
            matriculeOriginal = "";
            btnEnregistrer.Text = "Enregistrer";
        }

        private void ChargerEmployes()
        {
            try
            {
                System.Data.DataTable dt = employeDAO.ListerEmploye();

                if (!dt.Columns.Contains("Selection"))
                {
                    System.Data.DataColumn colSelect = new System.Data.DataColumn("Selection", typeof(bool));
                    colSelect.DefaultValue = false;
                    dt.Columns.Add(colSelect);
                    colSelect.SetOrdinal(0);
                }

                dataGridViewEmployes.AutoGenerateColumns = true;
                dataGridViewEmployes.DataSource = dt;

                if (dataGridViewEmployes.Columns.Contains("Selection"))
                {
                    dataGridViewEmployes.Columns["Selection"].HeaderText = "Sélectionner";
                    dataGridViewEmployes.Columns["Selection"].FillWeight = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des employés : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            dataGridViewEmployes.EndEdit();

            var confirmation = MessageBox.Show("Voulez-vous vraiment supprimer les employés sélectionnés ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation != DialogResult.Yes) return;

            int compteur = 0;

            foreach (DataGridViewRow row in dataGridViewEmployes.Rows)
            {
                if (row.IsNewRow) continue;

                var valeurCellule = row.Cells["Selection"].Value;

                if (valeurCellule != null && valeurCellule != DBNull.Value && Convert.ToBoolean(valeurCellule))
                {
                    string matricule = row.Cells["Matricule"].Value?.ToString();

                    if (!string.IsNullOrEmpty(matricule))
                    {
                        try
                        {
                            if (employeDAO.SupprimerEmploye(matricule))
                                compteur++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Impossible de supprimer l'employé {matricule}.\n\nErreur : {ex.Message}",
                                "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            if (compteur > 0)
            {
                MessageBox.Show($"{compteur} employé(s) supprimé(s) avec succès.", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerEmployes();
            }
            else
            {
                MessageBox.Show("Veuillez cocher au moins un employé à supprimer.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridViewEmployes.CurrentRow == null || dataGridViewEmployes.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Veuillez sélectionner un employé à modifier.", "Attentio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var row = dataGridViewEmployes.CurrentRow;

            txtMatricule.Text = row.Cells["Matricule"].Value?.ToString();
            txtNom.Text = row.Cells["Nom"].Value?.ToString();
            txtPrenom.Text = row.Cells["Prenom"].Value?.ToString();
            txtPoste.Text = row.Cells["Poste"].Value?.ToString();
            txtMotDePasse.Text = "";

            matriculeOriginal = txtMatricule.Text;
            modeModification = true;
            txtMatricule.Enabled = false;

            btnEnregistrer.Text = "Modifier";

        }
    }
}