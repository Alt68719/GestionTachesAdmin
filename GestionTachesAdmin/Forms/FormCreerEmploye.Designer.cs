using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GestionTachesAdmin
{
    partial class FormCreationEmploye
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
            lblMatricule = new Label();
            txtMatricule = new TextBox();
            lblNom = new Label();
            txtNom = new TextBox();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            lblPoste = new Label();
            txtPoste = new TextBox();
            btnEnregistrer = new Button();
            SuspendLayout();

            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(40, 50, 70);
            lblHeader.Location = new Point(25, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(313, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Créer un Nouvel Employé";

            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMatricule.Location = new Point(25, 75);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(93, 23);
            lblMatricule.TabIndex = 1;
            lblMatricule.Text = "Matricule :";

            // 
            // txtMatricule
            // 
            txtMatricule.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtMatricule.Location = new Point(25, 102);
            txtMatricule.Name = "txtMatricule";
            txtMatricule.Size = new Size(430, 30);
            txtMatricule.TabIndex = 2;

            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNom.Location = new Point(25, 150);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(57, 23);
            lblNom.TabIndex = 3;
            lblNom.Text = "Nom :";

            // 
            // txtNom
            // 
            txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNom.Location = new Point(25, 177);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(430, 30);
            txtNom.TabIndex = 4;

            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPrenom.Location = new Point(25, 225);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(79, 23);
            lblPrenom.TabIndex = 5;
            lblPrenom.Text = "Prénom :";

            // 
            // txtPrenom
            // 
            txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPrenom.Location = new Point(25, 252);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(430, 30);
            txtPrenom.TabIndex = 6;

            // 
            // lblPoste
            // 
            lblPoste.AutoSize = true;
            lblPoste.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPoste.Location = new Point(25, 300);
            lblPoste.Name = "lblPoste";
            lblPoste.Size = new Size(61, 23);
            lblPoste.TabIndex = 7;
            lblPoste.Text = "Poste :";

            // 
            // txtPoste
            // 
            txtPoste.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPoste.Location = new Point(25, 327);
            txtPoste.Name = "txtPoste";
            txtPoste.Size = new Size(430, 30);
            txtPoste.TabIndex = 8;

            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.FromArgb(40, 167, 69);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(25, 390);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(430, 45);
            btnEnregistrer.TabIndex = 9;
            btnEnregistrer.Text = "Enregistrer l'Employé";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;

            // 
            // FormCreationEmploye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(482, 465);
            Controls.Add(btnEnregistrer);
            Controls.Add(txtPoste);
            Controls.Add(lblPoste);
            Controls.Add(txtPrenom);
            Controls.Add(lblPrenom);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(txtMatricule);
            Controls.Add(lblMatricule);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormCreationEmploye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Création d'Employé";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblMatricule;
        private TextBox txtMatricule;
        private Label lblNom;
        private TextBox txtNom;
        private Label lblPrenom;
        private TextBox txtPrenom;
        private Label lblPoste;
        private TextBox txtPoste;
        private Button btnEnregistrer;
    }
}