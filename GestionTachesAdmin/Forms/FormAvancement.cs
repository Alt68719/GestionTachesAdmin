using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;
using GestionTachesAdmin.Forms.Models;
using GestionTachesAdmin.Models;

namespace GestionTachesAdmin
{
    public partial class FormAvancement : Form
    {
        public FormAvancement()
        {
            InitializeComponent();
        }

        private void FormAvancement_Load(object sender, EventArgs e)
        {
            chargerdonnes();
        }

        public void chargerdonnes()
        {
            try
            {
                List<Avancement> avancements = AvancementDAO.GetAvancement();

                // 1. On empêche la création automatique des colonnes en double
                dgvAvancement.AutoGenerateColumns = false;

                // 2. On indique à chaque colonne du Designer quelle propriété de l'objet lire
                colNom.DataPropertyName = "NomEmp";
                colPrenom.DataPropertyName = "PrenomEmp";
                colTache.DataPropertyName = "TacheName";
                colAvancement.DataPropertyName = "statut";

                // 3. On charge les données
                dgvAvancement.DataSource = null;
                dgvAvancement.DataSource = avancements;

                // Plus besoin de renommer les colonnes avec des 'if', 
                // car tes colonnes dans le Designer ont déjà les bons titres !
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            chargerdonnes();
        }
    }
}