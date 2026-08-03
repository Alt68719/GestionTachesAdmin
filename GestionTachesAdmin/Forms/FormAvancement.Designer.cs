using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionTachesAdmin
{
    partial class FormAvancement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitre = new Label();
            dgvAvancement = new DataGridView();
            colNom = new DataGridViewTextBoxColumn();
            colPrenom = new DataGridViewTextBoxColumn();
            colTache = new DataGridViewTextBoxColumn();
            colAvancement = new DataGridViewTextBoxColumn();
            btnActualiser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAvancement).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(40, 50, 70);
            lblTitre.Location = new Point(25, 20);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(382, 37);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Historique des Avancements";
            // 
            // dgvAvancement
            // 
            dgvAvancement.AllowUserToAddRows = false;
            dgvAvancement.AllowUserToDeleteRows = false;
            dgvAvancement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvancement.BackgroundColor = Color.White;
            dgvAvancement.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 50, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 50, 70);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAvancement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvancement.ColumnHeadersHeight = 40;
            dgvAvancement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAvancement.Columns.AddRange(new DataGridViewColumn[] { colNom, colPrenom, colTache, colAvancement });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAvancement.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAvancement.EnableHeadersVisualStyles = false;
            dgvAvancement.Location = new Point(25, 80);
            dgvAvancement.Name = "dgvAvancement";
            dgvAvancement.ReadOnly = true;
            dgvAvancement.RowHeadersVisible = false;
            dgvAvancement.RowHeadersWidth = 51;
            dgvAvancement.RowTemplate.Height = 35;
            dgvAvancement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvancement.Size = new Size(730, 400);
            dgvAvancement.TabIndex = 1;
            // 
            // colNom
            // 
            colNom.HeaderText = "Nom (Employé)";
            colNom.MinimumWidth = 6;
            colNom.Name = "colNom";
            colNom.ReadOnly = true;
            // 
            // colPrenom
            // 
            colPrenom.HeaderText = "Prénom (Employé)";
            colPrenom.MinimumWidth = 6;
            colPrenom.Name = "colPrenom";
            colPrenom.ReadOnly = true;
            // 
            // colTache
            // 
            colTache.HeaderText = "Tâche";
            colTache.MinimumWidth = 6;
            colTache.Name = "colTache";
            colTache.ReadOnly = true;
            // 
            // colAvancement
            // 
            colAvancement.HeaderText = "Avancement";
            colAvancement.MinimumWidth = 6;
            colAvancement.Name = "colAvancement";
            colAvancement.ReadOnly = true;
            // 
            // btnActualiser
            // 
            btnActualiser.BackColor = Color.FromArgb(0, 120, 215);
            btnActualiser.Cursor = Cursors.Hand;
            btnActualiser.FlatAppearance.BorderSize = 0;
            btnActualiser.FlatStyle = FlatStyle.Flat;
            btnActualiser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualiser.ForeColor = Color.White;
            btnActualiser.Location = new Point(605, 20);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(150, 40);
            btnActualiser.TabIndex = 2;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = false;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // FormAvancement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(782, 513);
            Controls.Add(btnActualiser);
            Controls.Add(dgvAvancement);
            Controls.Add(lblTitre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAvancement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suivi des Avancements";
            Load += FormAvancement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvancement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private DataGridView dgvAvancement;
        private DataGridViewTextBoxColumn colNom;
        private DataGridViewTextBoxColumn colPrenom;
        private DataGridViewTextBoxColumn colTache;
        private DataGridViewTextBoxColumn colAvancement;
        private Button btnActualiser;
    }
}