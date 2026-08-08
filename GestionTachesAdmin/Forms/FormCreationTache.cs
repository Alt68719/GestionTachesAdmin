using System;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;

namespace GestionTachesAdmin
{
    public partial class FormCreationTache : Form
    {
        private TacheDAO tacheDAO;
        private bool modeModification = false;
        private int id ;

        public FormCreationTache()
        {
            InitializeComponent();
            tacheDAO = new TacheDAO();
            ChargerTaches();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string titre = txtTitre.Text.Trim();
            string description = txtDescription.Text.Trim();
            string priorite = cmbPriorite.Text.Trim();
            DateTime dateLimite = dtpDateLimite.Value;

            if (string.IsNullOrEmpty(titre))
            {
                MessageBox.Show("Veuillez saisir un titre pour la tâche.", "Champ requis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitre.Focus();
                return;
            }

            try
            {
                bool succes;

                if (modeModification)
                {
                    succes = tacheDAO.ModifierTache(id, titre, description, dateLimite, priorite);
                    if (succes)
                        MessageBox.Show($"La tâche '{titre}' a été modifiée avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    succes = tacheDAO.AjouterTache(titre, description, priorite, dateLimite);
                    if (succes)
                        MessageBox.Show($"La tâche '{titre}' a été créée avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (succes)
                {
                    ReinitialiserFormulaire();
                    ChargerTaches();
                }
                else
                {
                    MessageBox.Show("Échec de l'opération.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur système : " + ex.Message, "Exception BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerTaches()
        {
            try
            {
                System.Data.DataTable dt = tacheDAO.ListerTache();

                if (!dt.Columns.Contains("Selection"))
                {
                    System.Data.DataColumn colSelect = new System.Data.DataColumn("Selection", typeof(bool));
                    colSelect.DefaultValue = false;
                    dt.Columns.Add(colSelect);
                    colSelect.SetOrdinal(0);
                }

                dataGridViewTache.AutoGenerateColumns = true;
                dataGridViewTache.DataSource = dt;

                if (dataGridViewTache.Columns.Contains("Selection"))
                {
                    dataGridViewTache.Columns["Selection"].HeaderText = "Sélectionner";
                    dataGridViewTache.Columns["Selection"].FillWeight = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des tâches : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTache.CurrentRow == null || dataGridViewTache.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Veuillez sélectionner une tâche dans le tableau.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridViewTache.CurrentRow;

            id = Convert.ToInt32(row.Cells["ID"].Value);
            txtTitre.Text = row.Cells["Titre"].Value?.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString();
            cmbPriorite.Text = row.Cells["Priorite"].Value?.ToString();
            dtpDateLimite.Value = Convert.ToDateTime(row.Cells["DateLimite"].Value);

            modeModification = true;
            btnCreer.Text = "Modifier";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            dataGridViewTache.EndEdit();

            var confirmation = MessageBox.Show("Voulez-vous vraiment supprimer les tâches sélectionnées ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation != DialogResult.Yes) return;

            int compteur = 0;

            foreach (DataGridViewRow row in dataGridViewTache.Rows)
            {
                if (row.IsNewRow) continue;

                var valeurCellule = row.Cells["Selection"].Value;

                if (valeurCellule != null && valeurCellule != DBNull.Value && Convert.ToBoolean(valeurCellule))
                {
                    string idTache = row.Cells["ID"].Value?.ToString();

                    if (!string.IsNullOrEmpty(idTache))
                    {
                        try
                        {
                            if (tacheDAO.SupprimerTache(idTache))
                                compteur++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Impossible de supprimer la tâche {idTache}.\n\nErreur : {ex.Message}",
                                "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            if (compteur > 0)
            {
                MessageBox.Show($"{compteur} tâche(s) supprimée(s) avec succès.", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerTaches();
            }
            else
            {
                MessageBox.Show("Veuillez cocher au moins une tâche à supprimer.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReinitialiserFormulaire()
        {
            txtTitre.Clear();
            txtDescription.Clear();
            dtpDateLimite.Value = DateTime.Now;
            cmbPriorite.SelectedIndex = -1;
            modeModification = false;
            id = 0;
            btnCreer.Text = "Créer";
        }
    }
}