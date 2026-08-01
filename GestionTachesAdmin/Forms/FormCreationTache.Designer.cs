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
            SuspendLayout();

            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(40, 50, 70);
            lblHeader.Location = new Point(25, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(311, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Créer une Nouvelle Tâche";

            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitre.Location = new Point(25, 75);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(138, 23);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Titre de la tâche :";

            // 
            // txtTitre
            // 
            txtTitre.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTitre.Location = new Point(25, 102);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(430, 30);
            txtTitre.TabIndex = 2;

            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDescription.Location = new Point(25, 150);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(105, 23);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description :";

            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            lblDateLimite.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDateLimite.Location = new Point(25, 305);
            lblDateLimite.Name = "lblDateLimite";
            lblDateLimite.Size = new Size(102, 23);
            lblDateLimite.TabIndex = 5;
            lblDateLimite.Text = "Date limite :";

            // 
            // dtpDateLimite
            // 
            dtpDateLimite.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpDateLimite.Format = DateTimePickerFormat.Short;
            dtpDateLimite.Location = new Point(25, 332);
            dtpDateLimite.Name = "dtpDateLimite";
            dtpDateLimite.Size = new Size(200, 30);
            dtpDateLimite.TabIndex = 6;

            // 
            // lblPriorite
            // 
            lblPriorite.AutoSize = true;
            lblPriorite.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPriorite.Location = new Point(255, 305);
            lblPriorite.Name = "lblPriorite";
            lblPriorite.Size = new Size(78, 23);
            lblPriorite.TabIndex = 7;
            lblPriorite.Text = "Priorité :";

            // 
            // cmbPriorite
            // 
            cmbPriorite.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriorite.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbPriorite.FormattingEnabled = true;
            cmbPriorite.Items.AddRange(new object[] { "Faible", "Moyenne", "Haute", "Urgente" });
            cmbPriorite.Location = new Point(255, 332);
            cmbPriorite.Name = "cmbPriorite";
            cmbPriorite.Size = new Size(200, 30);
            cmbPriorite.TabIndex = 8;
            cmbPriorite.SelectedIndex = 1; // "Moyenne" sélectionné par défaut

            // 
            // btnCreer
            // 
            btnCreer.BackColor = Color.FromArgb(40, 167, 69);
            btnCreer.Cursor = Cursors.Hand;
            btnCreer.FlatAppearance.BorderSize = 0;
            btnCreer.FlatStyle = FlatStyle.Flat;
            btnCreer.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreer.ForeColor = Color.White;
            btnCreer.Location = new Point(25, 390);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(430, 45);
            btnCreer.TabIndex = 9;
            btnCreer.Text = "Enregistrer la Tâche";
            btnCreer.UseVisualStyleBackColor = false;
            btnCreer.Click += btnCreer_Click;

            // 
            // FormCreationTache
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(482, 465);
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
    }
}