using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;
using GestionTachesAdmin.Forms.Models;
using GestionTachesAdmin.Models;

namespace GestionTachesAdmin
{
    public partial class FormAdmin : Form
    {
        private AttributionDAO attributionDAO;

        public int IdHistorique { get; private set; }

        public FormAdmin()
        {
            InitializeComponent();
            attributionDAO = new AttributionDAO();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            try
            {
                List<Employe> employes = attributionDAO.GetEmployes();
                cmbEmployes.DataSource = employes;
                cmbEmployes.DisplayMember = "NomComplet";
                cmbEmployes.ValueMember = "Matricule";

                List<Tache> taches = attributionDAO.GetTacheDispo();
                cmbTaches.DataSource = taches;
                cmbTaches.DisplayMember = "titre";
                cmbTaches.ValueMember = "Idtache";

                List<HistoriqueItem> historique = attributionDAO.GetHistorique();
                dgvHistorique.DataSource = null;
                dgvHistorique.DataSource = historique;

                if (dgvHistorique.Columns["IdHistorique"] != null)
                {
                    dgvHistorique.Columns["IdHistorique"].HeaderText = "ID";
                }
                if (dgvHistorique.Columns["actionRealisee"]!= null)
                {
                    dgvHistorique.Columns["actionRealisee"].HeaderText = "Action réalisée";
                }
                if (dgvHistorique.Columns["DateAction"] != null)
                {
                    dgvHistorique.Columns["DateAction"].HeaderText = "Date & Heure";
                }
                if (dgvHistorique.Columns["Employe"]!=null)
                {
                    dgvHistorique.Columns["Employe"].HeaderText = "Employé concerné";
                }
                if (dgvHistorique.Columns["Tache"]!=null)
                {
                    dgvHistorique.Columns["Tache"].HeaderText = "Tâche";
                }
                

                }
            catch (Exception ex)
            {
                 MessageBox.Show("Erreur lors du chargement des données : " + ex.Message + ", Erreur BD");
            }
        }

        private void btnAttribuer_Click(object sender, EventArgs e)
        {

            if (cmbEmployes.SelectedValue == null || cmbTaches.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un employé et une tâche.");
                return;
            }


            string matricule = cmbEmployes.SelectedValue.ToString();
            int idtache = (int)cmbTaches.SelectedValue;

            var liste = (List<Tache>)cmbTaches.DataSource;
            var tacheSelectionnee = liste.FirstOrDefault(t => t.Idtache == idtache);
            string titretache = tacheSelectionnee?.titre ?? "Titre inconnu";

            try
            {

                bool succes = attributionDAO.AttribuerEtNotifier(matricule, idtache, titretache);

                if (succes)
                {
                    MessageBox.Show($"La tâche '{titretache}' a été attribuée à l'employé '{matricule}' avec succès.");

                    ChargerDonnees();
                }
                else
                {
                    MessageBox.Show("Échec de l'attribution de la tâche.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'attribution de la tâche : " + ex.Message);
            }
        }

    }
}