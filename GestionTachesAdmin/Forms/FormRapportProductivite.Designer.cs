namespace GestionTachesAdmin.Forms
{
    partial class FormRapportProductivite
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.panelKPI = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTotalTaches = new System.Windows.Forms.Panel();
            this.lblTitreKpi1 = new System.Windows.Forms.Label();
            this.lblTotalTaches = new System.Windows.Forms.Label();
            this.cardTotalTerminees = new System.Windows.Forms.Panel();
            this.lblTitreKpi2 = new System.Windows.Forms.Label();
            this.lblTotalTerminees = new System.Windows.Forms.Label();
            this.cardTauxMoyen = new System.Windows.Forms.Panel();
            this.lblTitreKpi3 = new System.Windows.Forms.Label();
            this.lblTauxMoyen = new System.Windows.Forms.Label();
            this.panelContenu = new System.Windows.Forms.Panel();
            this.dgvRapports = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelKPI.SuspendLayout();
            this.cardTotalTaches.SuspendLayout();
            this.cardTotalTerminees.SuspendLayout();
            this.cardTauxMoyen.SuspendLayout();
            this.panelContenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnActualiser);
            this.panelHeader.Controls.Add(this.lblTitre);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitre.Location = new System.Drawing.Point(20, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(320, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "📊 Dashboard de Productivité";
            // 
            // btnActualiser
            // 
            this.btnActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnActualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Location = new System.Drawing.Point(850, 18);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(120, 35);
            this.btnActualiser.TabIndex = 1;
            this.btnActualiser.Text = "🔄 Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            // 
            // panelKPI
            // 
            this.panelKPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelKPI.Controls.Add(this.cardTotalTaches);
            this.panelKPI.Controls.Add(this.cardTotalTerminees);
            this.panelKPI.Controls.Add(this.cardTauxMoyen);
            this.panelKPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKPI.Location = new System.Drawing.Point(0, 70);
            this.panelKPI.Name = "panelKPI";
            this.panelKPI.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelKPI.Size = new System.Drawing.Size(1000, 100);
            this.panelKPI.TabIndex = 1;
            // 
            // cardTotalTaches
            // 
            this.cardTotalTaches.BackColor = System.Drawing.Color.White;
            this.cardTotalTaches.Controls.Add(this.lblTotalTaches);
            this.cardTotalTaches.Controls.Add(this.lblTitreKpi1);
            this.cardTotalTaches.Location = new System.Drawing.Point(25, 20);
            this.cardTotalTaches.Margin = new System.Windows.Forms.Padding(10);
            this.cardTotalTaches.Name = "cardTotalTaches";
            this.cardTotalTaches.Size = new System.Drawing.Size(280, 75);
            this.cardTotalTaches.TabIndex = 0;
            // 
            // lblTitreKpi1
            // 
            this.lblTitreKpi1.AutoSize = true;
            this.lblTitreKpi1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitreKpi1.ForeColor = System.Drawing.Color.Gray;
            this.lblTitreKpi1.Location = new System.Drawing.Point(15, 10);
            this.lblTitreKpi1.Name = "lblTitreKpi1";
            this.lblTitreKpi1.Size = new System.Drawing.Size(142, 15);
            this.lblTitreKpi1.TabIndex = 0;
            this.lblTitreKpi1.Text = "Total Tâches Assignées";
            // 
            // lblTotalTaches
            // 
            this.lblTotalTaches.AutoSize = true;
            this.lblTotalTaches.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalTaches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalTaches.Location = new System.Drawing.Point(15, 32);
            this.lblTotalTaches.Name = "lblTotalTaches";
            this.lblTotalTaches.Size = new System.Drawing.Size(26, 30);
            this.lblTotalTaches.TabIndex = 1;
            this.lblTotalTaches.Text = "0";
            // 
            // cardTotalTerminees
            // 
            this.cardTotalTerminees.BackColor = System.Drawing.Color.White;
            this.cardTotalTerminees.Controls.Add(this.lblTotalTerminees);
            this.cardTotalTerminees.Controls.Add(this.lblTitreKpi2);
            this.cardTotalTerminees.Location = new System.Drawing.Point(325, 20);
            this.cardTotalTerminees.Margin = new System.Windows.Forms.Padding(10);
            this.cardTotalTerminees.Name = "cardTotalTerminees";
            this.cardTotalTerminees.Size = new System.Drawing.Size(280, 75);
            this.cardTotalTerminees.TabIndex = 1;
            // 
            // lblTitreKpi2
            // 
            this.lblTitreKpi2.AutoSize = true;
            this.lblTitreKpi2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitreKpi2.ForeColor = System.Drawing.Color.Gray;
            this.lblTitreKpi2.Location = new System.Drawing.Point(15, 10);
            this.lblTitreKpi2.Name = "lblTitreKpi2";
            this.lblTitreKpi2.Size = new System.Drawing.Size(107, 15);
            this.lblTitreKpi2.TabIndex = 0;
            this.lblTitreKpi2.Text = "Tâches Terminées";
            // 
            // lblTotalTerminees
            // 
            this.lblTotalTerminees.AutoSize = true;
            this.lblTotalTerminees.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalTerminees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalTerminees.Location = new System.Drawing.Point(15, 32);
            this.lblTotalTerminees.Name = "lblTotalTerminees";
            this.lblTotalTerminees.Size = new System.Drawing.Size(26, 30);
            this.lblTotalTerminees.TabIndex = 1;
            this.lblTotalTerminees.Text = "0";
            // 
            // cardTauxMoyen
            // 
            this.cardTauxMoyen.BackColor = System.Drawing.Color.White;
            this.cardTauxMoyen.Controls.Add(this.lblTauxMoyen);
            this.cardTauxMoyen.Controls.Add(this.lblTitreKpi3);
            this.cardTauxMoyen.Location = new System.Drawing.Point(625, 20);
            this.cardTauxMoyen.Margin = new System.Windows.Forms.Padding(10);
            this.cardTauxMoyen.Name = "cardTauxMoyen";
            this.cardTauxMoyen.Size = new System.Drawing.Size(280, 75);
            this.cardTauxMoyen.TabIndex = 2;
            // 
            // lblTitreKpi3
            // 
            this.lblTitreKpi3.AutoSize = true;
            this.lblTitreKpi3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitreKpi3.ForeColor = System.Drawing.Color.Gray;
            this.lblTitreKpi3.Location = new System.Drawing.Point(15, 10);
            this.lblTitreKpi3.Name = "lblTitreKpi3";
            this.lblTitreKpi3.Size = new System.Drawing.Size(155, 15);
            this.lblTitreKpi3.TabIndex = 0;
            this.lblTitreKpi3.Text = "Taux de Complétion Moyen";
            // 
            // lblTauxMoyen
            // 
            this.lblTauxMoyen.AutoSize = true;
            this.lblTauxMoyen.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTauxMoyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblTauxMoyen.Location = new System.Drawing.Point(15, 32);
            this.lblTauxMoyen.Name = "lblTauxMoyen";
            this.lblTauxMoyen.Size = new System.Drawing.Size(46, 30);
            this.lblTauxMoyen.TabIndex = 1;
            this.lblTauxMoyen.Text = "0%";
            // 
            // panelContenu
            // 
            this.panelContenu.Controls.Add(this.dgvRapports);
            this.panelContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenu.Location = new System.Drawing.Point(0, 170);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Padding = new System.Windows.Forms.Padding(20);
            this.panelContenu.Size = new System.Drawing.Size(1000, 480);
            this.panelContenu.TabIndex = 2;
            // 
            // dgvRapports
            // 
            this.dgvRapports.AllowUserToAddRows = false;
            this.dgvRapports.AllowUserToDeleteRows = false;
            this.dgvRapports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRapports.Location = new System.Drawing.Point(20, 20);
            this.dgvRapports.Name = "dgvRapports";
            this.dgvRapports.ReadOnly = true;
            this.dgvRapports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRapports.Size = new System.Drawing.Size(960, 440);
            this.dgvRapports.TabIndex = 0;
            // 
            // FormRapportProductivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelContenu);
            this.Controls.Add(this.panelKPI);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRapportProductivite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport de Productivité des Employés";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelKPI.ResumeLayout(false);
            this.cardTotalTaches.ResumeLayout(false);
            this.cardTotalTaches.PerformLayout();
            this.cardTotalTerminees.ResumeLayout(false);
            this.cardTotalTerminees.PerformLayout();
            this.cardTauxMoyen.ResumeLayout(false);
            this.cardTauxMoyen.PerformLayout();
            this.panelContenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.FlowLayoutPanel panelKPI;
        private System.Windows.Forms.Panel cardTotalTaches;
        private System.Windows.Forms.Label lblTitreKpi1;
        private System.Windows.Forms.Label lblTotalTaches;
        private System.Windows.Forms.Panel cardTotalTerminees;
        private System.Windows.Forms.Label lblTitreKpi2;
        private System.Windows.Forms.Label lblTotalTerminees;
        private System.Windows.Forms.Panel cardTauxMoyen;
        private System.Windows.Forms.Label lblTitreKpi3;
        private System.Windows.Forms.Label lblTauxMoyen;
        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.DataGridView dgvRapports;
    }
}