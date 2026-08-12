using GestionTachesAdmin.DataAccess;
using GestionTachesAdmin.Forms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionTachesAdmin.Forms
{
    public partial class FormCommentaireEmp : Form
    {
        private string matricule;
        private ListesTachesEmpDAO _tacheService = new ListesTachesEmpDAO();
        private CommentaireEmpDAO _commentaireService = new CommentaireEmpDAO();
        private List<ListesTachesEmp> _listeTaches = new List<ListesTachesEmp>();

        public FormCommentaireEmp()
        {
            InitializeComponent();
            this.matricule = string.Empty;
        }

        public FormCommentaireEmp(string matricule)
        {
            InitializeComponent();
            this.matricule = matricule ?? string.Empty;
        }

        // Événement de chargement du formulaire
        private void FormCommentaireEmp_Load(object sender, EventArgs e)
        {
            ChargerListeTaches();
        }

        private void ChargerListeTaches()
        {
            try
            {
                if (string.IsNullOrEmpty(matricule)) return;

                _listeTaches = _tacheService.GetListesTachesParEmps(matricule);

                cmbTaches.DataSource = null;
                cmbTaches.DisplayMember = "titre";
                cmbTaches.ValueMember = "Idtache";
                cmbTaches.DataSource = _listeTaches;

                if (_listeTaches.Count > 0)
                {
                    cmbTaches.SelectedIndex = 0;
                    ChargerCommentairesTache();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des tâches : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerCommentairesTache()
        {
            try
            {
                lstCommentaires.Items.Clear();

                if (cmbTaches.SelectedValue != null && int.TryParse(cmbTaches.SelectedValue.ToString(), out int idTache))
                {
                    var commentaires = _commentaireService.GetCommentairesParTache(idTache);

                    foreach (var c in commentaires)
                    {
                        string auteur = (c.Matricule == this.matricule) ? "Moi" : c.Matricule;
                        lstCommentaires.Items.Add($"[{c.DateCommentaire:dd/MM/yyyy HH:mm}] {auteur} : {c.Contenu}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture des commentaires : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evenement declenche lors du changement de selection dans la ComboBox
        private void cmbTaches_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ChargerCommentairesTache();
        }

        // Evenement declenche au clic sur le bouton Envoyer
        private void btnEnvoyerCommentaire_Click_1(object sender, EventArgs e)
        {
            string texteCommentaire = txtNouveauCommentaire.Text.Trim();

            if (string.IsNullOrEmpty(texteCommentaire))
            {
                MessageBox.Show("Veuillez saisir un commentaire.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTaches.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une tâche.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTache = Convert.ToInt32(cmbTaches.SelectedValue);

                bool succes = _commentaireService.AjouterCommentaire(idTache, this.matricule, texteCommentaire);

                if (succes)
                {
                    txtNouveauCommentaire.Clear();
                    ChargerCommentairesTache();
                }
                else
                {
                    MessageBox.Show("Impossible d'enregistrer le commentaire dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur d'envoi : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}