using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionTachesAdmin
{
    partial class FormMenuPrincipal
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
            btnOuvrirCreation = new Button();
            btnOuvrirCreationEmploye = new Button();
            btnOuvrirAttribution = new Button();
            btnOuvrirAvancement = new Button();
            btnCommentaires = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(40, 50, 70);
            lblHeader.Location = new Point(312, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(210, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Menu Principal";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Click += lblHeader_Click;
            // 
            // btnOuvrirCreation
            // 
            btnOuvrirCreation.BackColor = Color.FromArgb(0, 122, 204);
            btnOuvrirCreation.Cursor = Cursors.Hand;
            btnOuvrirCreation.FlatAppearance.BorderSize = 0;
            btnOuvrirCreation.FlatStyle = FlatStyle.Flat;
            btnOuvrirCreation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOuvrirCreation.ForeColor = Color.White;
            btnOuvrirCreation.Location = new Point(246, 62);
            btnOuvrirCreation.Name = "btnOuvrirCreation";
            btnOuvrirCreation.Size = new Size(350, 50);
            btnOuvrirCreation.TabIndex = 1;
            btnOuvrirCreation.Text = "Création de Nouvelle Tâche";
            btnOuvrirCreation.UseVisualStyleBackColor = false;
            btnOuvrirCreation.Click += btnOuvrirCreation_Click;
            // 
            // btnOuvrirCreationEmploye
            // 
            btnOuvrirCreationEmploye.BackColor = Color.FromArgb(0, 122, 204);
            btnOuvrirCreationEmploye.Cursor = Cursors.Hand;
            btnOuvrirCreationEmploye.FlatAppearance.BorderSize = 0;
            btnOuvrirCreationEmploye.FlatStyle = FlatStyle.Flat;
            btnOuvrirCreationEmploye.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOuvrirCreationEmploye.ForeColor = Color.White;
            btnOuvrirCreationEmploye.Location = new Point(246, 138);
            btnOuvrirCreationEmploye.Name = "btnOuvrirCreationEmploye";
            btnOuvrirCreationEmploye.Size = new Size(350, 50);
            btnOuvrirCreationEmploye.TabIndex = 2;
            btnOuvrirCreationEmploye.Text = "Création d'Employé";
            btnOuvrirCreationEmploye.UseVisualStyleBackColor = false;
            btnOuvrirCreationEmploye.Click += btnOuvrirCreationEmploye_Click;
            // 
            // btnOuvrirAttribution
            // 
            btnOuvrirAttribution.BackColor = Color.FromArgb(0, 122, 204);
            btnOuvrirAttribution.Cursor = Cursors.Hand;
            btnOuvrirAttribution.FlatAppearance.BorderSize = 0;
            btnOuvrirAttribution.FlatStyle = FlatStyle.Flat;
            btnOuvrirAttribution.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOuvrirAttribution.ForeColor = Color.White;
            btnOuvrirAttribution.Location = new Point(246, 215);
            btnOuvrirAttribution.Name = "btnOuvrirAttribution";
            btnOuvrirAttribution.Size = new Size(350, 50);
            btnOuvrirAttribution.TabIndex = 3;
            btnOuvrirAttribution.Text = "Attribution et Historique";
            btnOuvrirAttribution.UseVisualStyleBackColor = false;
            btnOuvrirAttribution.Click += btnOuvrirAttribution_Click;
            // 
            // btnOuvrirAvancement
            // 
            btnOuvrirAvancement.BackColor = Color.FromArgb(0, 122, 204);
            btnOuvrirAvancement.Cursor = Cursors.Hand;
            btnOuvrirAvancement.FlatAppearance.BorderSize = 0;
            btnOuvrirAvancement.FlatStyle = FlatStyle.Flat;
            btnOuvrirAvancement.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOuvrirAvancement.ForeColor = Color.White;
            btnOuvrirAvancement.Location = new Point(246, 289);
            btnOuvrirAvancement.Name = "btnOuvrirAvancement";
            btnOuvrirAvancement.Size = new Size(350, 50);
            btnOuvrirAvancement.TabIndex = 4;
            btnOuvrirAvancement.Text = "Avancement des Tâche";
            btnOuvrirAvancement.UseVisualStyleBackColor = false;
            btnOuvrirAvancement.Click += btnOuvrirAvancement_Click;
            // 
            // btnCommentaires
            // 
            btnCommentaires.BackColor = Color.FromArgb(0, 122, 204);
            btnCommentaires.Cursor = Cursors.Hand;
            btnCommentaires.FlatAppearance.BorderSize = 0;
            btnCommentaires.FlatStyle = FlatStyle.Flat;
            btnCommentaires.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCommentaires.ForeColor = Color.White;
            btnCommentaires.Location = new Point(246, 364);
            btnCommentaires.Name = "btnCommentaires";
            btnCommentaires.Size = new Size(350, 50);
            btnCommentaires.TabIndex = 5;
            btnCommentaires.Text = " Listes des Commentaires";
            btnCommentaires.UseVisualStyleBackColor = false;
            btnCommentaires.Click += btnCommentaires_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(875, 485);
            Controls.Add(btnCommentaires);
            Controls.Add(lblHeader);
            Controls.Add(btnOuvrirAvancement);
            Controls.Add(btnOuvrirAttribution);
            Controls.Add(btnOuvrirCreationEmploye);
            Controls.Add(btnOuvrirCreation);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des Tâches - Accueil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnOuvrirCreation;
        private Button btnOuvrirCreationEmploye;
        private Button btnOuvrirAttribution;
        private Button btnOuvrirAvancement;
        private Button button1;
        private Button btnCommentaires;
    }
}