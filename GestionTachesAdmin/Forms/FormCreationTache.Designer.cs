using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionTachesAdmin
{
    partial class FormCreationTache
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
            lblHeader = new Label();
            lblTitre = new Label();
            txtTitre = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblDateLimite = new Label();
            dtpDateLimite = new DateTimePicker();
            lblPriorite = new Label();
            cmbPriorite = new ComboBox();
            btnCreer = new Button();
            dataGridViewTache = new DataGridView();
            label1 = new Label();
            btnSupprimer = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTache).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(40, 50, 70);
            lblHeader.Location = new Point(25, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(305, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Créer une Nouvelle Tâche";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitre.Location = new Point(25, 75);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(142, 23);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Titre de la tâche :";
            // 
            // txtTitre
            // 
            txtTitre.Font = new Font("Segoe UI", 10F);
            txtTitre.Location = new Point(25, 102);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(430, 30);
            txtTitre.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDescription.Location = new Point(25, 150);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(105, 23);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(25, 177);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(430, 110);
            txtDescription.TabIndex = 4;
            // 
            // lblDateLimite
            // 
            lblDateLimite.AutoSize = true;
            lblDateLimite.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDateLimite.Location = new Point(25, 305);
            lblDateLimite.Name = "lblDateLimite";
            lblDateLimite.Size = new Size(102, 23);
            lblDateLimite.TabIndex = 5;
            lblDateLimite.Text = "Date limite :";
            // 
            // dtpDateLimite
            // 
            dtpDateLimite.Font = new Font("Segoe UI", 10F);
            dtpDateLimite.Format = DateTimePickerFormat.Short;
            dtpDateLimite.Location = new Point(25, 332);
            dtpDateLimite.Name = "dtpDateLimite";
            dtpDateLimite.Size = new Size(200, 30);
            dtpDateLimite.TabIndex = 6;
            // 
            // lblPriorite
            // 
            lblPriorite.AutoSize = true;
            lblPriorite.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPriorite.Location = new Point(255, 305);
            lblPriorite.Name = "lblPriorite";
            lblPriorite.Size = new Size(74, 23);
            lblPriorite.TabIndex = 7;
            lblPriorite.Text = "Priorité :";
            // 
            // cmbPriorite
            // 
            cmbPriorite.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriorite.Font = new Font("Segoe UI", 10F);
            cmbPriorite.FormattingEnabled = true;
            cmbPriorite.Items.AddRange(new object[] { "Faible", "Moyenne", "Haute", "Urgente" });
            cmbPriorite.Location = new Point(255, 332);
            cmbPriorite.Name = "cmbPriorite";
            cmbPriorite.Size = new Size(200, 31);
            cmbPriorite.TabIndex = 8;
            // 
            // btnCreer
            // 
            btnCreer.BackColor = Color.FromArgb(40, 167, 69);
            btnCreer.Cursor = Cursors.Hand;
            btnCreer.FlatAppearance.BorderSize = 0;
            btnCreer.FlatStyle = FlatStyle.Flat;
            btnCreer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreer.ForeColor = Color.White;
            btnCreer.Location = new Point(25, 390);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(430, 45);
            btnCreer.TabIndex = 9;
            btnCreer.Text = "Enregistrer la Tâche";
            btnCreer.UseVisualStyleBackColor = false;
            btnCreer.Click += btnCreer_Click;
            // 
            // 
            // dataGridViewTache (lecture seule + design)
            // 
            dataGridViewTache.ReadOnly = true;
            dataGridViewTache.AllowUserToOrderColumns = false;
            dataGridViewTache.AllowUserToResizeRows = false;
            dataGridViewTache.MultiSelect = false;
            dataGridViewTache.BackgroundColor = Color.White;
            dataGridViewTache.BorderStyle = BorderStyle.None;
            dataGridViewTache.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTache.GridColor = Color.FromArgb(230, 230, 230);
            dataGridViewTache.EnableHeadersVisualStyles = false;
            dataGridViewTache.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 50, 70);
            dataGridViewTache.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewTache.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewTache.ColumnHeadersHeight = 38;
            dataGridViewTache.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dataGridViewTache.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 230, 245);
            dataGridViewTache.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewTache.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dataGridViewTache.RowTemplate.Height = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(751, 6);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 11;
            label1.Text = "Liste des Tâches";
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = SystemColors.ControlLight;
            btnSupprimer.Location = new Point(677, 463);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 12;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLight;
            btnUpdate.Location = new Point(855, 463);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormCreationTache
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1112, 492);
            Controls.Add(btnUpdate);
            Controls.Add(btnSupprimer);
            Controls.Add(label1);
            Controls.Add(dataGridViewTache);
            Controls.Add(btnCreer);
            Controls.Add(cmbPriorite);
            Controls.Add(lblPriorite);
            Controls.Add(dtpDateLimite);
            Controls.Add(lblDateLimite);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtTitre);
            Controls.Add(lblTitre);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormCreationTache";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Création de Tâche";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTache).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblTitre;
        private TextBox txtTitre;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblDateLimite;
        private DateTimePicker dtpDateLimite;
        private Label lblPriorite;
        private ComboBox cmbPriorite;
        private Button btnCreer;
        private DataGridView dataGridViewTache;
        private Label label1;
        private Button btnSupprimer;
        private Button btnUpdate;
    }
}