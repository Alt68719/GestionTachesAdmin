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
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPoste = new System.Windows.Forms.Label();
            this.txtPoste = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(80, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(200, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Création d'un Employé";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(40, 80);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(56, 13);
            this.lblMatricule.TabIndex = 1;
            this.lblMatricule.Text = "Matricule :";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(130, 77);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(200, 20);
            this.txtMatricule.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(40, 120);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 117);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(40, 160);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(130, 157);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Location = new System.Drawing.Point(40, 200);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(40, 13);
            this.lblPoste.TabIndex = 7;
            this.lblPoste.Text = "Poste :";
            // 
            // txtPoste
            // 
            this.txtPoste.Location = new System.Drawing.Point(130, 197);
            this.txtPoste.Name = "txtPoste";
            this.txtPoste.Size = new System.Drawing.Size(200, 20);
            this.txtPoste.TabIndex = 8;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(40, 240);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(77, 13);
            this.lblMotDePasse.TabIndex = 9;
            this.lblMotDePasse.Text = "Mot de passe :";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(130, 237);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(200, 20);
            this.txtMotDePasse.TabIndex = 10;
            // IMPORTANT : Cette propriété masque la saisie (remplace par des points)
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(130, 280);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(120, 35);
            this.btnEnregistrer.TabIndex = 11;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FormCreationEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 350);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txtPoste);
            this.Controls.Add(this.lblPoste);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormCreationEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un employé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.TextBox txtPoste;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}