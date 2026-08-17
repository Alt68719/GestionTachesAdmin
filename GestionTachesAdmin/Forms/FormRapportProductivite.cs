using GestionTachesAdmin.Forms.Dao;
using GestionTachesAdmin.Forms.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionTachesAdmin.Forms
{
    public partial class FormRapportProductivite : Form
    {
        private RapportProductiviteDAO _dao;

        public FormRapportProductivite()
        {
            InitializeComponent();
            _dao = new RapportProductiviteDAO();

            // Attachement des événements
            this.btnActualiser.Click += (s, e) => ChargerDonnees();
            this.Load += (s, e) => Form_Load();
        }

        private void Form_Load()
        {
            StyliserGrid();
            ChargerDonnees();
        }

        private void StyliserGrid()
        {
            dgvRapports.EnableHeadersVisualStyles = false;
            dgvRapports.BorderStyle = BorderStyle.None;
            dgvRapports.BackgroundColor = Color.White;
            dgvRapports.GridColor = Color.FromArgb(230, 230, 230);
            dgvRapports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapports.RowHeadersVisible = false;
            dgvRapports.RowTemplate.Height = 40;

            // En-tête du tableau
            dgvRapports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRapports.ColumnHeadersHeight = 45;
            dgvRapports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 35, 42);
            dgvRapports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRapports.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);

            // Style des cellules
            dgvRapports.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 250);
            dgvRapports.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvRapports.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgvRapports.CellFormatting += DgvRapports_CellFormatting;
        }

        private void ChargerDonnees()
        {
            try
            {
                List<RapportProductivite> liste = _dao.GenererRapportGlobal();

                dgvRapports.DataSource = null;
                dgvRapports.DataSource = liste;

                ConfigColonnes();
                MettreAJourKPIs(liste);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigColonnes()
        {
            if (dgvRapports.Columns["EmployeId"] != null)
                dgvRapports.Columns["EmployeId"].HeaderText = "ID Employé";

            if (dgvRapports.Columns["EmployeNom"] != null)
                dgvRapports.Columns["EmployeNom"].HeaderText = "Nom Employé";

            if (dgvRapports.Columns["TachesAssignees"] != null)
                dgvRapports.Columns["TachesAssignees"].HeaderText = "Assignées";

            if (dgvRapports.Columns["TachesTerminees"] != null)
                dgvRapports.Columns["TachesTerminees"].HeaderText = "Terminées";

            if (dgvRapports.Columns["TachesEnCours"] != null)
                dgvRapports.Columns["TachesEnCours"].HeaderText = "En Cours";

            if (dgvRapports.Columns["HeuresTravaillees"] != null)
                dgvRapports.Columns["HeuresTravaillees"].HeaderText = "Heures (h)";

            if (dgvRapports.Columns["TauxCompletion"] != null)
            {
                dgvRapports.Columns["TauxCompletion"].HeaderText = "Taux de Complétion";
                dgvRapports.Columns["TauxCompletion"].DefaultCellStyle.Format = "0.00'%'";
            }
        }

        private void MettreAJourKPIs(List<RapportProductivite> liste)
        {
            int totalAssignees = liste.Sum(r => r.TachesAssignees);
            int totalTerminees = liste.Sum(r => r.TachesTerminees);
            double tauxMoyen = liste.Count > 0 ? liste.Average(r => r.TauxCompletion) : 0;

            lblTotalTaches.Text = totalAssignees.ToString();
            lblTotalTerminees.Text = totalTerminees.ToString();
            lblTauxMoyen.Text = $"{Math.Round(tauxMoyen, 1)}%";
        }

        private void DgvRapports_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRapports.Columns[e.ColumnIndex].Name == "TauxCompletion" && e.Value != null)
            {
                if (double.TryParse(e.Value.ToString(), out double taux))
                {
                    if (taux >= 80)
                        e.CellStyle.ForeColor = Color.Green;
                    else if (taux >= 50)
                        e.CellStyle.ForeColor = Color.Orange;
                    else
                        e.CellStyle.ForeColor = Color.Red;

                    e.CellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
            }
        }
    }
}