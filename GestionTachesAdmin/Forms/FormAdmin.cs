using GestionTachesAdmin.DataAccess;
using GestionTachesAdmin.Models;

namespace GestionTachesAdmin
{
    public partial class FormAdmin : Form
    {
        private AttributionDAO attributionDAO;
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
                cmbEmployes.DisplayMember = "Matricule";

                List<Tache> taches = attributionDAO.GetTacheDispo();
                cmbTaches.DataSource = taches;
                cmbTaches.DisplayMember = "titre";
                cmbTaches.ValueMember = "Idtache";


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
            Tache tacheselectionner = (Tache)cmbTaches.SelectedValue;
            string titretache = tacheselectionner.titre;

            try
            {
                bool succes = attributionDAO.AttribuerTache(matricule, idtache);
                if (succes)
                {
                    MessageBox.Show($"La tâche '{titretache}' a été attribuée à l'employé '{matricule}' avec succès.");
                    ChargerDonnees(); // Recharger les données pour mettre à jour la liste des tâches disponibles
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

