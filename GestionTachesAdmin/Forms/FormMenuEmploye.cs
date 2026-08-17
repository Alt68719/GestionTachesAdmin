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

            if (this.tabControl1 != null)
            {
                this.tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            }
        }

        private async void FormAdmin_load(object? sender, EventArgs e)
        {
            AppliquerStyleGrid();
            AppliquerStyleGridNotif();
            ConfigDataGridView();
            ChargerFormulaireCommentaire();


            if (!string.IsNullOrEmpty(this.matricule))
            {
                await AfficherTaches(this.matricule);
            }
            else
            {
                MessageBox.Show("Erreur : Aucun matricule d'employé détecté.");
            }
        }

        private void tabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                ChargerFormulaireCommentaire();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                // On charge uniquement les notifications ici
                chargerNotification();

                // /!\ La ligne ConfigDataGridView() a été retirée car elle configurait 
                // le tableau des tâches au lieu du tableau des notifications.
            }
        }

        private void chargerNotification()
        {
            try
            {
                NotificationDAO notificationDAO = new NotificationDAO();
                List<Notification> list = notificationDAO.GetNotifications(this.matricule);

                dataGridViewNotif.DataSource = null;
                dataGridViewNotif.DataSource = list;
                if (dataGridViewNotif.Columns.Count > 0)
                {
                    dataGridViewNotif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des notifications : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerFormulaireCommentaire()
        {
            if (tabControl1.TabPages.Count < 2) return;

            TabPage tabCommentairePage = tabControl1.TabPages[1];

            if (tabCommentairePage.Controls.Count > 0 && tabCommentairePage.Controls[0] is FormCommentaireEmp)
            {
                return;
            }

            FormCommentaireEmp formCommentaire = new FormCommentaireEmp(this.matricule);
            formCommentaire.TopLevel = false;
            formCommentaire.FormBorderStyle = FormBorderStyle.None;
            formCommentaire.Dock = DockStyle.Fill;

            tabCommentairePage.Controls.Clear();
            tabCommentairePage.Controls.Add(formCommentaire);
            formCommentaire.Show();
        }
        private void AppliquerStyleGridNotif()
        {
            // Désactiver les styles visuels par défaut de Windows
            dataGridViewNotif.EnableHeadersVisualStyles = false;
            dataGridViewNotif.BorderStyle = BorderStyle.None;
            dataGridViewNotif.BackgroundColor = Color.White;
            dataGridViewNotif.GridColor = Color.FromArgb(230, 230, 230); 
            dataGridViewNotif.Dock = DockStyle.Fill;
            dataGridViewNotif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNotif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewNotif.ColumnHeadersHeight = 40;
            dataGridViewNotif.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 35, 42); 
            dataGridViewNotif.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewNotif.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            dataGridViewNotif.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 35, 42);
            dataGridViewNotif.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewNotif.DefaultCellStyle.BackColor = Color.White;
            dataGridViewNotif.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewNotif.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridViewNotif.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240); 
            dataGridViewNotif.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);

           
            dataGridViewNotif.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            
            dataGridViewNotif.RowTemplate.Height = 45;
            dataGridViewNotif.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewNotif.RowHeadersVisible = false; 
            dataGridViewNotif.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNotif.AllowUserToAddRows = false;
            dataGridViewNotif.AllowUserToResizeRows = false;
        }
        private void AppliquerStyleGrid()
        {
            dataGridViewTaches.EnableHeadersVisualStyles = false;
            dataGridViewTaches.BorderStyle = BorderStyle.None;
            dataGridViewTaches.BackgroundColor = Color.White;

            dataGridViewTaches.Dock = DockStyle.None;
            dataGridViewTaches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewTaches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewTaches.ColumnHeadersHeight = 35;
            dataGridViewTaches.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewTaches.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewTaches.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewTaches.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridViewTaches.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dataGridViewTaches.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewTaches.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dataGridViewTaches.RowTemplate.Height = 28;

            dataGridViewTaches.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 243, 250);
            dataGridViewTaches.GridColor = Color.FromArgb(220, 224, 230);
            dataGridViewTaches.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTaches.RowHeadersVisible = false;
        }

        private void ConfigDataGridView()
        {
            dataGridViewTaches.AutoGenerateColumns = false;
            dataGridViewTaches.Columns.Clear();

            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "titre",
                HeaderText = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridViewTaches.Columns.Add(colDescription);

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "date_limite",
                HeaderText = "Limite",
                Width = 120,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewTaches.Columns.Add(colDate);

            DataGridViewTextBoxColumn colPriorite = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "priorite",
                HeaderText = "Priorité",
                Width = 100,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            dataGridViewTaches.Columns.Add(colPriorite);

            DataGridViewTextBoxColumn colStatu = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "status",
                HeaderText = "Statut",
                Width = 100,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            dataGridViewTaches.Columns.Add(colStatu);

            DataGridViewButtonColumn colAction = new DataGridViewButtonColumn
            {
                Name = "colAction",
                HeaderText = "Action",
                UseColumnTextForButtonValue = false,
                Width = 140,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
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
                    .OrderBy(t => t.status)
                    .ThenBy(t => t.date_limite)
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
                if (row?.DataBoundItem is ListesTachesEmp tache)
                {
                    var cellStyle = row.DefaultCellStyle;
                    if (cellStyle != null)
                    {
                        if (string.Equals(tache.status, "Terminé", StringComparison.OrdinalIgnoreCase))
                        {
                            cellStyle.BackColor = Color.LightGreen;
                        }
                        else if (tache.date_limite < DateTime.Now)
                        {
                            cellStyle.BackColor = Color.LightGray;
                        }
                        else
                        {
                            cellStyle.BackColor = row.Index % 2 == 0 ? Color.White : Color.FromArgb(235, 243, 250);
                        }
                    }
                }
            }
        }

        private void DataGridViewTaches_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var column = dataGridViewTaches.Columns[e.ColumnIndex];
            if (column == null) return;

            if (column.Name == "colAction")
            {
                var row = dataGridViewTaches.Rows[e.RowIndex];
                if (row?.DataBoundItem is ListesTachesEmp tache)
                {
                    bool estTermine = string.Equals(tache.status, "Terminé", StringComparison.OrdinalIgnoreCase);
                    e.Value = estTermine ? "Rouvrir" : "Marquer Terminé";
                    e.FormattingApplied = true;
                }
            }

            if (column.DataPropertyName == "priorite" && e.Value != null)
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
                    bool estTermine = string.Equals(tacheSelectionnee.status, "Terminé", StringComparison.OrdinalIgnoreCase);
                    string nouveauStatut = estTermine ? "En cours" : "Terminé";

                    bool succes = _service.ChangerStatutTache(tacheSelectionnee.Idtache, nouveauStatut);

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