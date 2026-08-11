using GestionTachesAdmin.DataAccess;
using GestionTachesAdmin.Forms.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTachesAdmin.Forms
{
    public partial class FormMenuEmploye : Form
    {
        private string matricule;
        private ListesTachesEmpDAO _service = new ListesTachesEmpDAO();
        private List<ListesTachesEmp> _tachesActuelles = new List<ListesTachesEmp>();

        public FormMenuEmploye(string matricule)
        {
            InitializeComponent();
            this.matricule = matricule ?? string.Empty;
            this.Load += new EventHandler(this.FormAdmin_load);
        }

        private async void FormAdmin_load(object? sender, EventArgs e)
        {
            ConfigDataGridView();

            if (!string.IsNullOrEmpty(this.matricule))
            {
                await AfficherTaches(this.matricule);
            }
            else
            {
                MessageBox.Show("Erreur : Aucun matricule d'employé détecté.");
            }
        }

        private void ConfigDataGridView()
        {
            dataGridViewTaches.AutoGenerateColumns = false;
            dataGridViewTaches.Columns.Clear();

            //Description
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Titre_Tache",
                HeaderText = "Description",
                Width = 300
            };
            dataGridViewTaches.Columns.Add(colDescription);

            //Date limite
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date_Lime_Tache",
                HeaderText = "Limite",
                Width = 120
            };
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewTaches.Columns.Add(colDate);

            //Priorite
            DataGridViewTextBoxColumn colPriorite = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Priorite_Tache",
                HeaderText = "Priorité",
                Width = 100
            };
            dataGridViewTaches.Columns.Add(colPriorite);

            //Statut
            DataGridViewTextBoxColumn colStatu = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Statut_Tache",
                HeaderText = "Statut",
                Width = 100
            };
            dataGridViewTaches.Columns.Add(colStatu);

            //Action
            DataGridViewButtonColumn colAction = new DataGridViewButtonColumn
            {
                Name = "colAction",
                HeaderText = "Action",
                UseColumnTextForButtonValue = false,
                Width = 130
            };
            dataGridViewTaches.Columns.Add(colAction);
            dataGridViewTaches.CellFormatting -= DataGridViewTaches_CellFormatting;
            dataGridViewTaches.CellFormatting += DataGridViewTaches_CellFormatting;

            dataGridViewTaches.CellContentClick -= dataGridViewTaches_CellContentClick;
            dataGridViewTaches.CellContentClick += dataGridViewTaches_CellContentClick;
        }

        private async Task AfficherTaches(string matriculeCode)
        {
            try
            {
                _tachesActuelles = _service.GetListesTachesParEmps(matriculeCode);

                _tachesActuelles = _tachesActuelles
                    .OrderBy(t => t.Statut_Tache)
                    .ThenBy(t => t.Date_Lime_Tache)
                    .ToList();

                dataGridViewTaches.DataSource = null;
                dataGridViewTaches.DataSource = _tachesActuelles;

                ColorerLignes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur SQL/Connexion : {ex.Message}");
            }
        }

        private void ColorerLignes()
        {
            foreach (DataGridViewRow row in dataGridViewTaches.Rows)
            {
                if (row.DataBoundItem is ListesTachesEmp tache)
                {
                    if (tache.Statut_Tache)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void DataGridViewTaches_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var column = dataGridViewTaches.Columns[e.ColumnIndex];
            if (column == null) return;

            //Statut
            if (column.DataPropertyName == "Statut_Tache" && e.Value != null)
            {
                if (e.Value is bool estTermine)
                {
                    e.Value = estTermine ? "Terminé" : "En cours";
                    e.FormattingApplied = true;
                }
            }

            //action
            if (column.Name == "colAction")
            {
                var row = dataGridViewTaches.Rows[e.RowIndex];
                if (row?.DataBoundItem is ListesTachesEmp tache)
                {
                    e.Value = tache.Statut_Tache ? "Rouvrir" : "Marquer Terminé";
                    e.FormattingApplied = true;
                }
            }
            if (column.DataPropertyName == "Priorite_Tache" && e.Value != null)
            {
                string priorite = e.Value.ToString() ?? string.Empty;
                switch (priorite)
                {
                    case "Haute":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                    case "Moyenne":
                        e.CellStyle.ForeColor = Color.Orange;
                        break;
                    case "Basse":
                        e.CellStyle.ForeColor = Color.Green;
                        break;
                }
            }
        }

        private async void dataGridViewTaches_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var column = dataGridViewTaches.Columns[e.ColumnIndex];
            if (column != null && column.Name == "colAction")
            {
                dataGridViewTaches.CommitEdit(DataGridViewDataErrorContexts.Commit);

                var row = dataGridViewTaches.Rows[e.RowIndex];
                if (row?.DataBoundItem is ListesTachesEmp tacheSelectionnee)
                {
                    string nouveauStatut = tacheSelectionnee.Statut_Tache ? "En cours" : "Terminé";

                    bool succes = _service.ChangerStatutTache(tacheSelectionnee.Id_tache, nouveauStatut);

                    if (succes)
                    {
                        await AfficherTaches(this.matricule);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la mise à jour en base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormAdmin_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
