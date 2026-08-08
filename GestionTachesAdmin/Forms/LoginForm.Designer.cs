using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTachesAdmin
{
    partial class FormLogin
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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(115, 25);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(134, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Connexion";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIdentifiant.Location = new System.Drawing.Point(40, 90);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(127, 17);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant / Matricule :";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtIdentifiant.Location = new System.Drawing.Point(43, 115);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(280, 24);
            this.txtIdentifiant.TabIndex = 2;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMotDePasse.Location = new System.Drawing.Point(40, 160);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(94, 17);
            this.lblMotDePasse.TabIndex = 3;
            this.lblMotDePasse.Text = "Mot de passe :";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMotDePasse.Location = new System.Drawing.Point(43, 185);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(280, 24);
            this.txtMotDePasse.TabIndex = 4;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(43, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(280, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 320);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion - Gestion des Tâches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnLogin;
    }
}